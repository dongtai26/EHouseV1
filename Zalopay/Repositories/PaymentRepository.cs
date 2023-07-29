using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zalopay.Healper;
using Zalopay.Models;
using ZaloPay.Helper.Crypto;

namespace Zalopay.Repositories
{
    public class PaymentRepository : IPaymentRepository
    {
        public async Task<CreateOrderResponse> CreateOrder(CreateOrderRequest request)
        {
            string app_id = "2553";
            string key1 = "PcY4iZIKFCIdgZvA6ueMcMHHUbRLYjPL";
            string create_order_url = "https://sb-openapi.zalopay.vn/v2/create";
            Random rnd = new Random();
            var embed_data = new { };
            var items = new[] { new { } };
            var param = new Dictionary<string, string>();
            var app_trans_id = rnd.Next(1000000);
            CreateOrderResponse createOrderResponse = new();
            param.Add("app_id", app_id);
            param.Add("app_user", request.AppUser.ToString());
            param.Add("app_time", Utils.GetTimeStamp().ToString());
            param.Add("amount", request.Amount.ToString());
            param.Add("app_trans_id", DateTime.Now.ToString("yyMMdd") + "_" + app_trans_id); // mã giao dich có định dạng yyMMdd_xxxx
            param.Add("embed_data", JsonConvert.SerializeObject(embed_data));
            param.Add("item", JsonConvert.SerializeObject(items));
            param.Add("description", "Ehouse - Thanh toán đơn hàng #" + app_trans_id);
            param.Add("bank_code", "zalopayapp");
            var data = app_id + "|" + param["app_trans_id"] + "|" + param["app_user"] + "|" + param["amount"] + "|"
            + param["app_time"] + "|" + param["embed_data"] + "|" + param["item"];
            param.Add("mac", HmacHelper.Compute(ZaloPayHMAC.HMACSHA256, key1, data));
            var result = await HttpHelper.PostFormAsync(create_order_url, param);
            createOrderResponse.ReturnCode = Int32.Parse($"{result.ElementAt(0).Value}");
            createOrderResponse.ReturnMessage = $"{result.ElementAt(1).Value}";
/*            createOrderResponse.SubReturnCode = Int32.Parse($"{result.ElementAt(2).Value}");
            createOrderResponse.SubReturnMessage = $"{result.ElementAt(3).Value}";*/
            createOrderResponse.ZPTransToken = $"{result.ElementAt(4).Value}";
            createOrderResponse.OrderUrl = $"{result.ElementAt(5).Value}";
            createOrderResponse.OrderToken = $"{result.ElementAt(6).Value}";
            createOrderResponse.AppTransId = DateTime.Now.ToString("yyMMdd") + "_" + app_trans_id;
            return createOrderResponse;
        }
        public async Task<CheckOrderResponse> CheckOrder(CheckOrderRequest checkOrderRequest)
        {
            string app_id = "2553";
            string key1 = "PcY4iZIKFCIdgZvA6ueMcMHHUbRLYjPL";
            string query_order_url = "https://sb-openapi.zalopay.vn/v2/query";
            var param = new Dictionary<string, string>();
            CheckOrderResponse checkOrderResponse = new();
            param.Add("app_id", app_id);
            param.Add("app_trans_id", checkOrderRequest.AppTransId);
            var data = app_id + "|" + checkOrderRequest.AppTransId + "|" + key1;
            param.Add("mac", HmacHelper.Compute(ZaloPayHMAC.HMACSHA256, key1, data));
            var result = await HttpHelper.PostFormAsync(query_order_url, param);
            checkOrderResponse.ReturnCode = Int32.Parse($"{result.ElementAt(0).Value}");
            checkOrderResponse.ReturnMessage = $"{result.ElementAt(1).Value}";
            /*            checkOrderResponse.SubReturnCode = Int32.Parse($"{result.ElementAt(2).Value}");
                        checkOrderResponse.SubReturnMessage = $"{result.ElementAt(3).Value}";*/
            checkOrderResponse.IsProcessing = bool.Parse($"{result.ElementAt(4).Value}");
            checkOrderResponse.Amount = long.Parse($"{result.ElementAt(5).Value}");
            checkOrderResponse.ZPTransId = long.Parse($"{result.ElementAt(6).Value}");
            return checkOrderResponse;
        }
    }
}
