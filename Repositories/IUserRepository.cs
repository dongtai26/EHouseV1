using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IUserRepository
    {
        List<UserDTO> GetUsers();
        void AddUser(UserDTO userDTO);
        void UpdateUser(UserDTO userDTO);
        void DeleteUser(int id);
    }
}
