﻿using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IUserRepository
    {
        UserDTO GetUser(UserDTO userDTO);
        UserDTO GetUserById(int id);
        UserDTO GetLastUser();
        List<UserDTO> GetUsers();
        void AddUser(UserDTO userDTO);
        void UpdateUser(UserDTO userDTO);
        void DeleteUser(int id);
        UserDTO Login(string username, string password);
        UserDTO ForgotPassword(string gmail, string username);
    }
}
