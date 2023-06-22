using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.Models;
using BusinessObjects.Data;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class UserDAO
    {
        public List<User> GetUsers()
        {
            var ListUser = new List<User>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListUser = context.Users.Include(m => m.Role).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListUser;
        }
        public void AddUser(User user)
        {
            try
            {
                var db = new AppDbContext();
                db.Users.Add(user);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void UpdateUser(User user)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    context.Entry<User>(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteUser(int id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var uDelete = context.Users.SingleOrDefault(x => x.UId == id);
                    context.Users.Remove(uDelete);
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
