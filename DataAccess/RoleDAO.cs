using BusinessObjects.Data;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class RoleDAO
    {
        public List<Role> GetRoles()
        {
            var ListUser = new List<Role>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListUser = context.Roles.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListUser;
        }
        public void AddRole(Role role)
        {
            try
            {
                var db = new AppDbContext();
                db.Roles.Add(role);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void UpdateRole(Role role)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    context.Entry<Role>(role).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteRole(int id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var rDelete = context.Roles.SingleOrDefault(x => x.RId == id);
                    context.Roles.Remove(rDelete);
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
