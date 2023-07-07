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
        public User GetUser(User user)
        {
            return user;
        }
        public User GetUserById(int id)
        {
            User user = new User();
            try
            {
                var db = new AppDbContext();
                user = db.Users.Include(m => m.Role).SingleOrDefault(x => x.UId == id);
            
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return user;
        }
        public User GetLastUser()
        {
            User user = new User();
            var ListUser = new List<User>();
            try
            {
                var db = new AppDbContext();
                user = db.Users.OrderBy(m => m.UId).Include(m => m.Role).Last();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return user;
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
        public User FindUserByUsernameAndPassword(string username, string password)
        {
            var p = new User();
            try
            {
                using (var context = new AppDbContext())
                {
                    p = context.Users.Include(m => m.Role).SingleOrDefault(x => x.Username == username && x.Password == password);
                    if (p == null)
                    {
                        throw new Exception("Wrong password or username");
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return p;
        }
        public User FindUserByUsernameAndGmail(string gmail, string username)
        {
            var p = new User();
            try
            {
                using (var context = new AppDbContext())
                {
                    p = context.Users.Include(m => m.Role).SingleOrDefault(x => x.Username == username && x.Gmail == gmail);
                    if (p == null)
                    {
                        throw new Exception("Username not match with Gmail");
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return p;
        }
    }
}
