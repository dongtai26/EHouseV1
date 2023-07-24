using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class MerchantDTO
    {
        public string merchantInfo { get; set; }
        public string appUserName { get; set; }
        public string amount { get; set; }
        public string orderId { get; set; }
    }
}
