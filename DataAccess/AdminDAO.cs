using BusinessObjects.Data;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AdminDAO
    {
        public List<Admin> GetAdmins()
        {
            var ListAdmin = new List<Admin>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListAdmin = context.Admins.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListAdmin;
        }
        public void AddAdmin(Admin admin)
        {
            try
            {
                var db = new AppDbContext();
                db.Admins.Add(admin);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteAdmin(int id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var aDelete = context.Admins.SingleOrDefault(x => x.UId == id);
                    context.Admins.Remove(aDelete);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public Admin GetAdminByUserId(int id)
        {
            Admin admin = new Admin();
            try
            {
                var db = new AppDbContext();
                admin = db.Admins.SingleOrDefault(x => x.UId == id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return admin;
        }
    }
}
