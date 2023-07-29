using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zalopay.Models;

namespace Zalopay.Repositories
{
    public interface IPaymentRepository
    {
        Task<CreateOrderResponse> CreateOrder(CreateOrderRequest request);
        Task<CheckOrderResponse> CheckOrder(CheckOrderRequest checkOrderRequest);
    }
}
