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
        List<UserDTO> GetUsersByRoleId(int id);
        UserDTO GetUser(UserDTO userDTO);
        UserDTO GetUserById(int id);
        UserDTO GetLastUser();
        List<UserDTO> GetUsers();
        void AddUser(UserDTO userDTO);
        void UpdateUser(UserDTO userDTO);
        void UpdateAvatarForUser(UserDTO userDTO);
        void DeleteUser(int id);
        UserDTO Login(string username, string password);
        UserDTO ForgotPassword(string gmail, string username);
        int CountTotalUser();
        bool CheckExistCitizenIdentification(UserDTO userDTO);
        bool CheckExistPhoneNumber(UserDTO userDTO);
        bool CheckExistGmail(UserDTO userDTO);
        bool CheckExistUsername(UserDTO userDTO);

    }
}
