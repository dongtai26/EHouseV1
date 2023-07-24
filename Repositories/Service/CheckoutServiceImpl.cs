using DataAccess.DTO;
using DataAccess.Helpers;
using DataAccess.Util;
using Newtonsoft.Json;
using Repositories.Zalopay.Config;
using Repositories.Zalopay.Request;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Repositories.Service
{
    public class CheckoutServiceImpl : ICheckoutService
    {
        static string app_id = "2553";
        static string key1 = "PcY4iZIKFCIdgZvA6ueMcMHHUbRLYjPL";
        static string key2 = "kLtgPl8HHhfvMuDHPwKfgfsY4Ydm9eIz";
        static string create_order_url = "https://sb-openapi.zalopay.vn/v2/create";
        private string appTransId = "";

        private readonly ZaloPayConfig zaloPayConfig;
        public MerchantResponse createMerchant(List<ItemDTO> itemsDTO, MerchantDTO merchantDTO)
        {
            
            Random random = new Random();
            var embed_data = new { };
            var randomId = random.Next(1000000);
            var paymentUrl = string.Empty;
            var param = new Dictionary<string, string>();
            List<Dictionary<string, object>> mapItems = new List<Dictionary<string, object>>();
            for (int i = 0; i < itemsDTO.Count; i++)
            {
                ItemDTO itemDto = itemsDTO[i];
                Dictionary<string, object> mapItem = new Dictionary<string, object>();

                mapItem["itemname"] = "zaloItem";
                mapItem["itemprice"] = int.Parse(itemDto.price);
                mapItem["itemquantity"] = int.Parse(itemDto.quantity);

                mapItems.Add(mapItem);
            }
            param.Add("app_trans_id", DateTime.Now.ToString("yyMMdd") + "_" + appTransId);
            param.Add("app_time", DateTime.Now.GetTimeStamp().ToString());
            param.Add("app_user", "abc123");
            param.Add("amount", long.Parse(merchantDTO.amount).ToString());
            param.Add("description", "Ehouse - Payment for the contract #" + randomId);
            param.Add("bank_code", "zalopayapp");
            param.Add("item", JsonConvert.SerializeObject(mapItems));
            param.Add("embed_data", JsonConvert.SerializeObject(embed_data).ToString());

            var data = app_id + "|" + param["app_trans_id"] + "|" + param["app_user"] + "|" + param["amount"] + "|"
               + param["app_time"] + "|" + param["embed_data"] + "|" + param["item"];
            param.Add("mac", HashHelper.HmacSHA256(data, key1));

            using (var client = new HttpClient())
            {
                var content = new FormUrlEncodedContent(param);
                var response = client.PostAsync(key1.ToString(), content).Result;
                var resultJsonStr = response.Content.ReadAsStringAsync().Result;
                var result = JsonObject.Parse(resultJsonStr);

                foreach (var pair in result)
                {
                    Console.WriteLine("{0} = {1}", pair.Key, pair.Value);
                }

                return new MerchantResponse(result["order_url"].ToString(), "TOK_" + appTransId);
            }

        }

        public PaymentStatusResponse statusPayment()
        {
            throw new NotImplementedException();
        }
    }
}
