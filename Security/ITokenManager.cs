using BusinessObjects.Models;
using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Security
{
    public interface ITokenManager
    {
        string GenerateNewToken(UserDTO user);
        ClaimsPrincipal VerifyToken(string token);
        public void AddUserValidTokenStorage(int UId);
        public void DeleteToken(int UId);
        public void SaveToken(int UId, string token);
        public UserToken GetUserValidTokenStorage(int UId);
    }
}
