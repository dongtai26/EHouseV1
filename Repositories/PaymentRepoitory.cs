using DataAccess;
using DataAccess.DTO;
using DataAccess.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class PaymentRepoitory : IPaymentRepoitory
    {
        PaymentDAO paymentDAO = new PaymentDAO();
        public void CreatePayment(PaymentDTO paymentDTO)
        {
            paymentDAO.CreatePayment(Mapper.mapToEntity(paymentDTO));
        }
    }
}
