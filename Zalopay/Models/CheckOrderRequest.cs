using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zalopay.Models
{
    public class CheckOrderRequest
    {
        public int AppId { get; set; }
        public string AppTransId { get; set; } = string.Empty;
    }
}
