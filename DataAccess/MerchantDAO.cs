using BusinessObjects.Data;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MerchantDAO
    {
        public List<Merchant> GetMerchants()
        {
            var listMerchant = new List<Merchant>();
            try
            {
                using (var context = new AppDbContext())
                {
                    listMerchant = context.Merchants.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listMerchant;
        }
        public void CreateMerchant(Merchant merchant)
        {
            try
            {
                var db = new AppDbContext();
                db.Merchants.Add(merchant);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteMerchant(string id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var mDelete = context.Merchants.Where(x => x.Id.Contains(id));
                    context.Merchants.Remove((Merchant)mDelete);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void EditMerchant(Merchant merchant)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    context.Entry<Merchant>(merchant).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public Merchant GetMerchantById(string id)
        {
            Merchant merchant = new Merchant();
            try
            {
                var db = new AppDbContext();
                merchant = (Merchant)db.Merchants.Where(x => x.Id.Contains(id));
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return merchant;
        }
    }
}
