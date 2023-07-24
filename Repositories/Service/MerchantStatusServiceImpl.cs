using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Service
{
    public class MerchantStatusServiceImpl : IMerchantStatusService
    {
        public MerchantStatus getStatusOrder(String orderId)
        {
            return new MerchantStatus("1", "DELIVERED");
        }
    }
}
