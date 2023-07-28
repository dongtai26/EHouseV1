using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zalopay.Models
{
    public class CreateOrderRequest
    {
        public int AppId { get; set; }
        public string AppUser { get; set; } = string.Empty;
        public long AppTime { get; set; }
        public long Amount { get; set; }
        public string AppTransId { get; set; } = string.Empty;
        public string EmbedData { get; set; } = string.Empty;
        public string Item { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string BankCode { get; set; } = string.Empty;
    }
}
