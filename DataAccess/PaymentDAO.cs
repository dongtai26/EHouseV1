using BusinessObjects.Data;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PaymentDAO
    {
        public void CreatePayment(Payment payment)
        {
            try
            {
                var db = new AppDbContext();
                db.Payments.Add(payment);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<Payment> GetPayments()
        {
            var ListPayment = new List<Payment>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListPayment = context.Payments.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListPayment;
        }
    }
}
