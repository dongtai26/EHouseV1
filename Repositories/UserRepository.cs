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
    }
}
