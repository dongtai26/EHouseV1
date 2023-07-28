using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zalopay.Models
{
    public class CreateOrderResponse
    {
        public int ReturnCode { get; set; }
        public string ReturnMessage { get; set; } = string.Empty;
/*        public int SubReturnCode { get; set; }
        public string SubReturnMessage { get; set; } = string.Empty;*/
        public string ZPTransToken { get; set; } = string.Empty;
        public string OrderUrl { get; set; } = string.Empty;
        public string OrderToken { get; set; } = string.Empty;
        public string AppTransId { get; set; } = string.Empty;
    }
}
