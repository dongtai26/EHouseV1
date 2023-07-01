using BusinessObjects.Data;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class UserTokenDAO
    {
        public UserToken FindUserTokenByUId(int UId)
        {
            var p = new UserToken();
            try
            {
                using (var context = new AppDbContext())
                {
                    p = context.UserTokens.SingleOrDefault(x => x.UId == UId);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return p;
        }
        public UserToken FindUserTokenByToken(string token)
        {
            var p = new UserToken();
            try
            {
                using (var context = new AppDbContext())
                {
                    p = context.UserTokens.SingleOrDefault(x => x.Jwt == token);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return p;
        }
        public void AddUserToken(UserToken userToken)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    context.UserTokens.Add(userToken);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void UpdateUserToken(UserToken userToken)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    context.Entry<UserToken>(userToken).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
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
