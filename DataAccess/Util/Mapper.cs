using BusinessObjects.Models;
using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Util
{
    public class Mapper
    {
        public static UserDTO mapToDTO(User user)
        {
            if (user != null)
            {
                UserDTO userDTO = new UserDTO
                {
                    UId = user.UId,
                    FullName = user.FullName,
                    Age = user.Age,
                    Address = user.Address,
                    CitizenIdentification = user.CitizenIdentification,
                    PhoneNumber = user.PhoneNumber,
                    Gender = user.Gender,
                    Gmail = user.Gmail,
                    Avatar = user.Avatar,
                    Username = user.Username,
                    Password = user.Password,
                    RId = user.RId,
                    RoleName = user.Role.RoleName
                };
                return userDTO;
            }
            else
            {
                return null;
            }
        }
        public static User mapToEntity(UserDTO userDTO)
        {
            User user = new User
            {
                UId = userDTO.UId,
                FullName = userDTO.FullName,
                Age = userDTO.Age,
                Address = userDTO.Address,
                CitizenIdentification = userDTO.CitizenIdentification,
                PhoneNumber = userDTO.PhoneNumber,
                Gender = userDTO.Gender,
                Gmail = userDTO.Gmail,
                Avatar = userDTO.Avatar,
                Username = userDTO.Username,
                Password = userDTO.Password,
                RId = userDTO.RId
            };
            return user;
        }
        public static RoleDTO mapToDTO(Role role)
        {
            if (role != null)
            {
                RoleDTO roleDTO = new RoleDTO
                {
                    RId = role.RId,
                    RoleName = role.RoleName
                };
                return roleDTO;
            }
            else
            {
                return null;
            }
        }
        public static Role mapToEntity(RoleDTO roleDTO)
        {
            Role role = new Role
            {
                RId = roleDTO.RId,
                RoleName = roleDTO.RoleName
            };
            return role;
        }
        public static AdminDTO mapToDTO(Admin admin)
        {
            if (admin != null)
            {
                AdminDTO adminDTO = new AdminDTO
                {
                    AdId = admin.AdId,
                    UId = admin.UId
                };
                return adminDTO;
            }
            else
            {
                return null;
            }
        }
        public static Admin mapToEntity(AdminDTO adminDTO)
        {
            Admin admin = new Admin
            {
                AdId = adminDTO.AdId,
                UId = adminDTO.UId
            };
            return admin;
        }
        public static LessorDTO mapToDTO(Lessor lessor)
        {
            if (lessor != null)
            {
                LessorDTO lessorDTO = new LessorDTO
                {
                    LeId = lessor.LeId,
                    UId = lessor.UId
                };
                return lessorDTO;
            }
            else
            {
                return null;
            }
        }
        public static Lessor mapToEntity(LessorDTO lessorDTO)
        {
            Lessor lessor = new Lessor
            {
                LeId = lessorDTO.LeId,
                UId = lessorDTO.UId
            };
            return lessor;
        }
        public static LesseeDTO mapToDTO(Lessee lessee)
        {
            if (lessee != null)
            {
                LesseeDTO lesseeDTO = new LesseeDTO
                {
                    LesId = lessee.LesId,
                    UId = lessee.UId
                };
                return lesseeDTO;
            }
            else
            {
                return null;
            }
        }
        public static Lessee mapToEntity(LesseeDTO lesseeDTO)
        {
            Lessee lessee = new Lessee
            {
                LesId = lesseeDTO.LesId,
                UId = lesseeDTO.UId
            };
            return lessee;
        }
        public static LocationDTO mapToDTO(Location location)
        {
            if (location != null)
            {
                LocationDTO locationDTO = new LocationDTO
                {
                    LId = location.LId,
                    Longitude = location.Longitude,
                    Latitude = location.Latitude,
                    Address = location.Address
                };
                return locationDTO;
            }
            else
            {
                return null;
            } 
        }
        public static Location mapToEntity(LocationDTO locationDTO)
        {
            Location location = new Location
            {
                LId = locationDTO.LId,
                Latitude = locationDTO.Latitude,
                Longitude = locationDTO.Longitude,
                Address = locationDTO.Address
            };
            return location;
        }
    }
}
