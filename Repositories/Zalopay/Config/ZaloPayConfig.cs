using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Zalopay.Config
{
    public class ZaloPayConfig
    {
        public static string ConfigName => "ZaloPay";
        public string AppUser { get; set; } = string.Empty;
        public string PaymentUrl { get; set; } = string.Empty;
        public string RedirecUrl { get; set; } = string.Empty;
        public string InpUrl { get; set; } = string.Empty;
        public int AppId { get; set; } 
        public string Key1 { get; set; } = string.Empty;
        public string Key2 { get; set; } = string.Empty;
    }
}
