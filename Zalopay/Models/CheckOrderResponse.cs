using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zalopay.Models
{
    public class CheckOrderResponse
    {
        public int ReturnCode { get; set; }
        public string ReturnMessage { get; set; } = string.Empty;
        public int SubReturnCode { get; set; }
        public string SubReturnMessage { get; set; } = string.Empty;
        public bool IsProcessing { get; set; }
        public long Amount { get; set; }
        public long ZPTransId { get; set; }
    }
}
