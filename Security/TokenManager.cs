using BusinessObjects.Models;
using DataAccess;
using DataAccess.DTO;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Security
{
    public class TokenManager : ITokenManager
    {
        private JwtSecurityTokenHandler tokenHandler;
        private byte[] secretKey;

        UserTokenDAO userTokenDAO = new UserTokenDAO();

        public TokenManager()
        {
            tokenHandler = new JwtSecurityTokenHandler();
            secretKey = Encoding.ASCII.GetBytes("ThisIsTheSecretKey");
        }
        public void AddUserValidTokenStorage(int UId)
        {
            UserToken token = new UserToken
            {
                UId = UId
            };
            userTokenDAO.AddUserToken(token);
        }
        public void SaveToken(int UId, string token)
        {
            UserToken userToken = userTokenDAO.FindUserTokenByUId(UId);
            userToken.Jwt = token;
            userTokenDAO.UpdateUserToken(userToken);
        }
        public void DeleteToken(int UId)
        {
            UserToken userToken = userTokenDAO.FindUserTokenByUId(UId);
            userToken.Jwt = null;
            userTokenDAO.UpdateUserToken(userToken);
        }
        public string GenerateNewToken(UserDTO user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.UId.ToString()),
                    new Claim(ClaimTypes.Role, user.RoleName)
                }),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(secretKey), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var jwtTokenString = tokenHandler.WriteToken(token);
            return jwtTokenString;
        }
        public UserToken GetUserValidTokenStorage(int Uid)
        {
            return userTokenDAO.FindUserTokenByUId(Uid);
        }
        public ClaimsPrincipal VerifyToken(string token)
        {
            string[] tokenPart = token.Split(' ');

            UserToken checkToken = userTokenDAO.FindUserTokenByToken(token);

            if (checkToken != null)
            {
                var claims = tokenHandler.ValidateToken(tokenPart[1],
                new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(secretKey),
                    ValidateLifetime = true,
                    ValidateAudience = false,
                    ValidateIssuer = false,
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validateJwtToken);
                return claims;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
