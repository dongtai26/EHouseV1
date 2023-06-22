using BusinessObjects.Data;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class LessorDAO
    {
        public void AddLessor(Lessor lessor)
        {
            try
            {
                var db = new AppDbContext();
                db.Lessors.Add(lessor);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteLessor(int id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var lDelete = context.Lessors.SingleOrDefault(x => x.UId == id);
                    context.Lessors.Remove(lDelete);
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
