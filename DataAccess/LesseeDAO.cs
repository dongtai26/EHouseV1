using BusinessObjects.Data;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class LesseeDAO
    {
        public List<Lessee> GetLessees()
        {
            var ListLessee = new List<Lessee>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListLessee = context.Lessees.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListLessee;
        }
        public void AddLessee(Lessee lessee)
        {
            try
            {
                var db = new AppDbContext();
                db.Lessees.Add(lessee);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteLessee(int id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var lDelete = context.Lessees.SingleOrDefault(x => x.UId == id);
                    context.Lessees.Remove(lDelete);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
