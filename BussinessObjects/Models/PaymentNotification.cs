using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public class PaymentNotification
    {
        [Key]
        public string Id { get; set; }
        public string PaymentRefId { get; set; }
        public string NotiDate { get; set; }
        public string NotiAmount { get; set; }
        public string NotiContent { get; set; }
        public string NotiMessage { get; set; }
        public string NotiSignature { get; set; }
        public string PaymentId { get; set; }
        [ForeignKey("ParentId")]
        public virtual Payment Payment { get; set; }
        public string MerchantId { get; set; }
        public string NotiStatus { get; set; }
        public string NotiResDate { get; set; }
    }
}
