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
        public List<Lessor> GetLessors()
        {
            var ListLessor = new List<Lessor>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListLessor = context.Lessors.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListLessor;
        }
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
        public Lessor GetLessorByUserId(int id)
        {
            Lessor lessor = new Lessor();
            try
            {
                var db = new AppDbContext();
                lessor = db.Lessors.SingleOrDefault(x => x.UId == id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return lessor;
        }
        public int CountTotalLessor()
        {
            int n;
            try
            {
                var db = new AppDbContext();
                n = db.Lessors.Count();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return n;
        }
    }
}
