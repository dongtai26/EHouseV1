using DataAccess.DTO;
using DataAccess.Helpers;
using EHouseAPI.Filter;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using Repositories;
using Repositories.Service;
using Repositories.Zalopay.Config;
using System.Text.Json.Nodes;

namespace EHouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : Controller 
    {
        private string key2 = "kLtgPl8HHhfvMuDHPwKfgfsY4Ydm9eIz";
        private readonly HashHelper HmacSHA256;
        private readonly ICheckoutService checkoutService;
        private readonly IMerchantStatusService merchantStatusService;
        private readonly ILogger<PaymentController> logger;

        public PaymentController (string key2, HashHelper hmacSHA256, ICheckoutService checkoutService, IMerchantStatusService merchantStatusService, ILogger<PaymentController> logger)
        {
            this.key2 = key2;
            HmacSHA256 = hmacSHA256;
            this.checkoutService = checkoutService;
            this.merchantStatusService = merchantStatusService;
            this.logger = logger;
        }
        /*[HttpPost]
        public MerchantResponse CreateOrder([FromBody] string jsonOrder)
        {
            JObject input = JObject.Parse(jsonOrder);
            JArray itemsJson = (JArray)input["_items"];
            JObject orderInfo = (JObject)input["_orderInfo"];
            var paymentUrl = string.Empty;
            List<ItemDTO> items = new List<ItemDTO>();
            foreach (JObject itemJson in itemsJson)
            {
                ItemDTO item = new ItemDTO
                {
                    Name = itemJson["_name"].ToString(),
                    Quantity = itemJson["_quantity"].ToString(),
                    Price = itemJson["_price"].ToString()
                };
                items.Add(item);
            }

            MerchantDTO order = new MerchantDTO
            {
                AppUserName = orderInfo["_appUserName"].ToString(),
                Amount = orderInfo["_amount"].ToString(),
                OrderId = orderInfo["_orderId"].ToString()
            };
            return this.checkoutService.CreateMerchant(items, order);
        }*/
    }
}
