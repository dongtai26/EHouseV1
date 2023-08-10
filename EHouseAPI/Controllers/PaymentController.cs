using EHouseAPI.Filter;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Repositories;
using Zalopay.Healper;
using Zalopay.Models;
using Zalopay.Repositories;
using ZaloPay.Helper.Crypto;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EHouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentRepository paymentRepository;
        public PaymentController(IPaymentRepository paymentRepository)
        {
            this.paymentRepository = paymentRepository;
        }
        [AuthorizationFilter]
        [HttpPost("CreateOrder")]
        public async Task<CreateOrderResponse> CreateOrder(CreateOrderRequest request)
        {
            return await paymentRepository.CreateOrder(request);
        }
        [AuthorizationFilter]
        [HttpPost("CheckOrder")]
        public async Task<CheckOrderResponse> CheckOrder(CheckOrderRequest request)
        {
            return await paymentRepository.CheckOrder(request);
        }
        /*[HttpPost("CallBack")]
        public IActionResult Post([FromBody] dynamic cbdata)
        {
            var result = new Dictionary<string, object>();
            string key2 = "eG4r0GcoNtRGbO8";
            try
            {
                var dataStr = Convert.ToString(cbdata["data"]);
                var reqMac = Convert.ToString(cbdata["mac"]);

                var mac = HmacHelper.Compute(ZaloPayHMAC.HMACSHA256, key2, dataStr);

                Console.WriteLine("mac = {0}", mac);

                // kiểm tra callback hợp lệ (đến từ ZaloPay server)
                if (!reqMac.Equals(mac))
                {
                    // callback không hợp lệ
                    result["return_code"] = -1;
                    result["return_message"] = "mac not equal";
                }
                else
                {
                    // thanh toán thành công
                    // merchant cập nhật trạng thái cho đơn hàng
                    var dataJson = JsonConvert.DeserializeObject<Dictionary<string, object>>(dataStr);
                    Console.WriteLine("update order's status = success where app_trans_id = {0}", dataJson["app_trans_id"]);

                    result["return_code"] = 1;
                    result["return_message"] = "success";
                }
            }
            catch (Exception ex)
            {
                result["return_code"] = 0; // ZaloPay server sẽ callback lại (tối đa 3 lần)
                result["return_message"] = ex.Message;
            }

            // thông báo kết quả cho ZaloPay server
            return Ok(result);
        }*/
    }
}
