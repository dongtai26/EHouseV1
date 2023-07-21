using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public class Payment
    {
        [Key]
        public string Id { get; set; }
        public string PaymentContent { get; set; }
        public string PaymentCurrency { get; set; }
        public string PaymentRefId { get; set; }
        public decimal RequiredAmoun { get; set; }
        public DateTime PaymentDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public string PaymentLanguage { get; set; }
        public string MerchantId { get; set; }
        [ForeignKey("MerchantId")]
        public virtual Merchant Merchant { get; set; }
        public string PaymentDestinationId { get; set; }
        [ForeignKey("PaymentDestinationId")]
        public virtual PaymentDestination PaymentDestination { get; set; }
        public decimal PaymentAmount { get; set; }
        public string PaymentStatus { get; set; }
        public string PaymentLastMessage { get; set; }
        public virtual ICollection<PaymentNotification> PaymentNotifications { get; set; }
        public virtual ICollection<PaymentSignature> PaymentSignatures { get; set; }
        public virtual ICollection<PaymentTransaction> PaymentTransactions { get; set; }
        public virtual ICollection<PaymentDestination> PaymentDestinations { get; set; }
    }
}
