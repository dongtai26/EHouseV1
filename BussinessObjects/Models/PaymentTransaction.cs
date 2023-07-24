using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public class PaymentTransaction
    {
        public string Id { get; set; }
        public string? TranMessage { get; set; }
        public string? TranPayload { get; set; }
        public string? TranAmount { get; set; }
        public DateTime? TranDate { get; set; }
        public string? PaymentId { get; set; }
        [ForeignKey("ParentId")]
        public virtual Payment Payment { get; set; }
        public string? TranRefId { get; set; }
    }
}
