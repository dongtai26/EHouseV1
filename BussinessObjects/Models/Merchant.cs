using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public class Merchant
    {
        [Key]
        public string Id { get; set; }
        public string? MerchantName { get; set; }
        public string? MerchantWebLink { get; set; }
        public string? MerchantIpnUrl { get; set; }
        public string? MerchantReturnUrl { get; set; }
        public string? SecretKey { get; set; }
        public bool IsActive { get; set; }
        public string? CreatedBy { get; set; }
        public string? LastUpdatedBy { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastUpdatedAt { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<PaymentNotification> PaymentNotifications { get; set; }
    }
}
