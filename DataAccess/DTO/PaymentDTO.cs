using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class PaymentDTO : IRequest<PaymentLinkDTO>
    {
        public string Id { get; set; }
        public string PaymentContent { get; set; }
        public string PaymentCurrency { get; set; }
        public string PaymentRefId { get; set; }
        public decimal? RequiredAmount { get; set; }
        public DateTime? PaymentDate { get; set; } = DateTime.Now;
        public DateTime? ExpireDate { get; set; } = DateTime.Now.AddMinutes(15);
        public string? PaymentLanguage { get; set; }
        public string? MerchantId { get; set; }
        public string? PaymentDestinationId { get; set; }
        public string? Signature { get; set; }
    }
}
