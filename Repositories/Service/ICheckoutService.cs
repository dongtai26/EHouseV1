using DataAccess.DTO;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Service
{
    public interface ICheckoutService
    {
        MerchantResponse createMerchant(List<ItemDTO> items, MerchantDTO merchantDTO);
        PaymentStatusResponse statusPayment();
    }
}
