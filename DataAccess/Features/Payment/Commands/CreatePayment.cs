using MediatR;
using DataAccess.DTO;

namespace DataAccess.Features.Payment.Commands
{
    public class CreatePayment : IRequest<PaymentLinkDTO>
    {
        public string PaymentContent { get; set; }
        public string PaymentCurrency { get; set; }
        public string PaymentRefId { get; set; }
        public decimal? RequiredAmount { get; set; }
        public DateTime? PaymentDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public string? PaymentLanguage { get; set; }
        public string? MerchantId { get; set; }
        public string? PaymentDestinationId { get; set; }
        public string? Signature { get; set; }
    }
   /* public class CreatePaymentHandler : IRequestHandler<CreatePayment, PaymentLinkDTO>
    {
        private readonly  
    }*/
}
