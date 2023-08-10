using DataAccess;
using DataAccess.DTO;
using DataAccess.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class UserRepository : IUserRepository
    {
        UserDAO userDAO = new UserDAO();
        public UserDTO GetUser(UserDTO userDTO)
        {
            return userDTO;
        }
        public UserDTO GetUserById(int id)
        {
            return Mapper.mapToDTO(userDAO.GetUserById(id));
        }
        public List<UserDTO> GetUsersByRoleId(int id)
        {
            return userDAO.GetUsersByRoleId(id).Select(m => Mapper.mapToDTO(m)).ToList();
        }
        public UserDTO GetLastUser()
        {
            return Mapper.mapToDTO(userDAO.GetLastUser());
        }
        public void AddUser(UserDTO userDTO)
        {
            userDAO.AddUser(Mapper.mapToEntity(userDTO));
        }

        public void DeleteUser(int id)
        {
            userDAO.DeleteUser(id);
        }

        public List<UserDTO> GetUsers()
        {
            return userDAO.GetUsers().Select(m => Mapper.mapToDTO(m)).ToList();
        }

        public void UpdateUser(UserDTO userDTO)
        {
            userDAO.UpdateUser(Mapper.mapToEntity(userDTO));
        }
        public void UpdateAvatarForUser(int id, UserAvatarDTO userAvatarDTO)
        {
            userDAO.UpdateUserAvatar(id, Mapper.mapToEntityAvatar(userAvatarDTO));
        }
        public UserDTO Login(string username, string password)
        {
            return Mapper.mapToDTO(userDAO.FindUserByUsernameAndPassword(username, password));
        }
        public UserDTO ForgotPassword(string gmail, string username)
        {
            return Mapper.mapToDTO(userDAO.FindUserByUsernameAndGmail(gmail, username));
        }
        public UserDTO GetUserDTOByRoleID(int roleId)
        {
            return Mapper.mapToDTO(userDAO.GetUserByRoleId(roleId));
        }
    }
}
