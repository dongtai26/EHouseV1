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
                    Dateofbirth = user.Dateofbirth,
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
                Dateofbirth = userDTO.Dateofbirth,
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
        public static User mapToEntityAvatar(UserDTO userDTO)
        {
            User user = new User
            {
                UId = userDTO.UId,
                Avatar = userDTO.Avatar,
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
        public static HouseRentDTO mapToDTO(HouseRent houseRent)
        {
            if (houseRent != null)
            {
                HouseRentDTO houseRentDTO = new HouseRentDTO
                {
                    HoId = houseRent.HoId,
                    HouseRentName = houseRent.HouseRentName,
                    Area = houseRent.Area,
                    AirConditioning = houseRent.AirConditioning,
                    WaterHeater = houseRent.WaterHeater,
                    Wifi = houseRent.Wifi,
                    WashingMachine = houseRent.WashingMachine,
                    Bed = houseRent.Bed,
                    Parking = houseRent.Parking,
                    Refrigerator = houseRent.Refrigerator,
                    Restroom = houseRent.Restroom,
                    Kitchen = houseRent.Kitchen,
                    ElectricityPrice = houseRent.ElectricityPrice,
                    WaterPrice = houseRent.WaterPrice,
                    RentPrice = houseRent.RentPrice,
                    HouseStatus = houseRent.HouseStatus,
                    Detail = houseRent.Detail,
                    LeId = houseRent.LeId
                };
                return houseRentDTO;
            }
            else
            {
                return null;
            }
        }
        public static HouseRent mapToEntity(HouseRentDTO houseRentDTO)
        {
            HouseRent houseRent = new HouseRent
            {
                HoId = houseRentDTO.HoId,
                HouseRentName = houseRentDTO.HouseRentName,
                Area = houseRentDTO.Area,
                AirConditioning = houseRentDTO.AirConditioning,
                WaterHeater = houseRentDTO.WaterHeater,
                Wifi = houseRentDTO.Wifi,
                WashingMachine = houseRentDTO.WashingMachine,
                Bed = houseRentDTO.Bed,
                Parking = houseRentDTO.Parking,
                Refrigerator = houseRentDTO.Refrigerator,
                Restroom = houseRentDTO.Restroom,
                Kitchen = houseRentDTO.Kitchen,
                ElectricityPrice = houseRentDTO.ElectricityPrice,
                WaterPrice = houseRentDTO.WaterPrice,
                RentPrice = houseRentDTO.RentPrice,
                HouseStatus = houseRentDTO.HouseStatus,
                Detail = houseRentDTO.Detail,
                Longitude = houseRentDTO.Longitude,
                Latitude = houseRentDTO.Latitude,
                Address = houseRentDTO.Address,
                LeId = houseRentDTO.LeId
            };
            return houseRent;
        }
        public static HouseRentAddressDTO mapToDTOAddress(HouseRent houseRent)
        {
            if (houseRent != null)
            {
                HouseRentAddressDTO houseRentDTO = new HouseRentAddressDTO
                {
                    HoId = houseRent.HoId,
                    Longitude = houseRent.Longitude,
                    Latitude = houseRent.Latitude,
                    Address = houseRent.Address
                };
                return houseRentDTO;
            }
            else
            {
                return null;
            }
        }
        public static HouseRent mapToEntityAddress(HouseRentAddressDTO houseRentAddressDTO)
        {
            HouseRent houseRent = new HouseRent
            {
                HoId = houseRentAddressDTO.HoId,
                Longitude = houseRentAddressDTO.Longitude,
                Latitude = houseRentAddressDTO.Latitude,
                Address = houseRentAddressDTO.Address
            };
            return houseRent;
        }
        public static ContractDTO mapToDTO(Contract contract)
        {
            if (contract != null)
            {
                ContractDTO contractDTO = new ContractDTO
                {
                    ConId = contract.ConId,
                    ContractApproveDay = contract.ContractApproveDay,
                    ContractContent = contract.ContractContent,
                    ContractCreatedDay = contract.ContractCreatedDay,
                    HoId = contract.HoId,
                    AdId = contract.AdId,
                    LeId = contract.LeId,
                    LesId = contract.LesId
                };
                return contractDTO;
            }
            else
            {
                return null;
            }
        }
        public static Contract mapToEntity(ContractDTO contractDTO)
        {
            Contract contract = new Contract
            {
                ConId = contractDTO.ConId,
                ContractApproveDay = contractDTO.ContractApproveDay,
                ContractContent = contractDTO.ContractContent,
                ContractCreatedDay = contractDTO.ContractCreatedDay,
                HoId = contractDTO.HoId,
                AdId = contractDTO.AdId,
                LeId = contractDTO.LeId,
                LesId = contractDTO.LesId
            };
            return contract;
        }
        public static HouseImageDTO mapToDTO(HouseImage houseImage)
        {
            if (houseImage != null)
            {
                HouseImageDTO houseImageDTO = new HouseImageDTO
                {
                    HIId = houseImage.HIId,
                    HouseImageCode = houseImage.HouseImageCode,
                    HoId = houseImage.HoId,
                };
                return houseImageDTO;
            }
            else
            {
                return null;
            }
        }
        public static HouseImage mapToEntity(HouseImageDTO houseImageDTO)
        {
            HouseImage houseImage = new HouseImage
            {
                HIId = houseImageDTO.HIId,
                HouseImageCode = houseImageDTO.HouseImageCode,
                HoId = houseImageDTO.HoId
            };
            return houseImage;
        }
        public static PostImageDTO mapToDTO(PostImage postImage)
        {
            if (postImage != null)
            {
                PostImageDTO postImageDTO = new PostImageDTO
                {
                    PIId = postImage.PIId,
                    PostImageUrl = postImage.PostImageUrl,
                    PostImageName = postImage.PostImageName,
                    PostImageContent = postImage.PostImageContent,
                    PId = postImage.PId
                };
                return postImageDTO;
            }
            else
            {
                return null;
            }
        }
        public static PostImage mapToEntity(PostImageDTO postImageDTO)
        {
            PostImage postImage = new PostImage
            {
                PIId = postImageDTO.PIId,
                PostImageUrl = postImageDTO.PostImageUrl,
                PostImageName = postImageDTO.PostImageName,
                PostImageContent = postImageDTO.PostImageContent,
                PId = postImageDTO.PId
            };
            return postImage;
        }
        public static PostDTO mapToDTO(Post post)
        {
            if (post != null)
            {
                PostDTO postDTO = new PostDTO
                {
                    PId = post.PId,
                    PostStatus = post.PostStatus,
                    AdId = post.AdId,
                    PostContent = post.PostContent,
                    PostCreatedDay = post.PostCreatedDay,
                    PostTitle = post.PostTitle,
                    UId = post.UId
                };
                return postDTO;
            }
            else
            {
                return null;
            }
        }
        public static Post mapToEntity(PostDTO postDTO)
        {
            Post post = new Post
            {
                PId = postDTO.PId,
                PostStatus = postDTO.PostStatus,
                AdId = postDTO.AdId,
                PostContent = postDTO.PostContent,
                PostCreatedDay = postDTO.PostCreatedDay,
                PostTitle = postDTO.PostTitle,
                UId = postDTO.UId
            };
            return post;
        }
        public static CommentDTO mapToDTO(Comment comment)
        {
            if (comment != null)
            {
                CommentDTO commentDTO = new CommentDTO
                {
                    CId = comment.CId,
                    CommentContent = comment.CommentContent,
                    LastTimeModified = comment.LastTimeModified,
                    PId = comment.PId,
                    UId = comment.UId

                };
                return commentDTO;
            }
            else
            {
                return null;
            }
        }
        public static Comment mapToEntity(CommentDTO commentDTO)
        {
            Comment comment = new Comment
            {
                CId = commentDTO.CId,
                CommentContent = commentDTO.CommentContent,
                LastTimeModified = commentDTO.LastTimeModified,
                PId = commentDTO.PId,
                UId = commentDTO.UId
            };
            return comment;
        }
        public static NotificationDTO mapToDTO(Notification notification)
        {
            if (notification != null)
            {
                NotificationDTO notificationDTO = new NotificationDTO
                {
                    NoId = notification.NoId,
                    NoContent = notification.NoContent,
                    NoName = notification.NoName,
                    PId = notification.PId,
                    UId = notification.UId,
                    CId = notification.CId,
                };
                return notificationDTO;
            }
            else
            {
                return null;
            }
        }
        public static Notification mapToEntity(NotificationDTO notificationDTO)
        {
            Notification notification = new Notification
            {
                NoId = notificationDTO.NoId,
                NoContent = notificationDTO.NoContent,
                NoName = notificationDTO.NoName,
                PId = notificationDTO.PId,
                UId = notificationDTO.UId,
                CId = notificationDTO.CId
            };
            return notification;
        }
    }
}
