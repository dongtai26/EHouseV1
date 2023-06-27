using DataAccess.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace EHouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;
        private readonly IAdminRepository adminRepository;
        private readonly ILesseeRepository lesseeRepository;
        private readonly ILessorRepository lessorRepository;
        public UserController(IUserRepository userRepository, IAdminRepository adminRepository, ILesseeRepository lesseeRepository, ILessorRepository lessorRepository)
        {
            this.userRepository = userRepository;
            this.adminRepository = adminRepository;
            this.lesseeRepository = lesseeRepository;
            this.lessorRepository = lessorRepository;
        }
        [HttpGet("GetUsers")]
        public IActionResult GetUsers()
        {
            return Ok(userRepository.GetUsers());
        }
        [HttpPost("AddUser")]
        public IActionResult AddUser(UserDTO user)
        {
            try
            {
                switch (user.RId)
                {
                    case 1:
                        userRepository.AddUser(user);
                        UserDTO lastUser = userRepository.GetLastUser();
                        AdminDTO adminDTO = new AdminDTO
                        {
                            AdId = 0,
                            UId = lastUser.UId
                        };
                        adminRepository.AddAdmin(adminDTO);
                        break;
                    case 2:
                        userRepository.AddUser(user);
                        UserDTO lastUser2 = userRepository.GetLastUser();
                        LessorDTO lessorDTO = new LessorDTO
                        {
                            LeId = 0,
                            UId = lastUser2.UId
                        };
                        lessorRepository.AddLessor(lessorDTO);
                        break;
                    case 3:
                        userRepository.AddUser(user);
                        UserDTO lastUser3 = userRepository.GetLastUser();
                        LesseeDTO lesseeDTO = new LesseeDTO
                        {
                            LesId = 0,
                            UId = lastUser3.UId
                        };
                        lesseeRepository.AddLessee(lesseeDTO);
                        break;
                }
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut("UpdateUser")]
        public IActionResult UpdateUser(UserDTO user)
        {
            try
            {
                UserDTO oldUser = userRepository.GetUserById(user.UId);
                userRepository.UpdateUser(user);
                UserDTO newUser = userRepository.GetUser(user);
                if (oldUser.RId != newUser.RId)
                {
                    IEnumerable<AdminDTO> adminList = adminRepository.GetAdmins();
                    foreach (AdminDTO admin in adminList)
                    {
                        if (admin.UId == user.UId)
                        {
                            adminRepository.DeleteAdmin(user.UId);
                        }
                    }
                    IEnumerable<LessorDTO> lessorList = lessorRepository.GetLessors();
                    foreach (LessorDTO lessor in lessorList)
                    {
                        if (lessor.UId == user.UId)
                        {
                            lessorRepository.DeleteLessor(user.UId);
                        }
                    }
                    IEnumerable<LesseeDTO> lesseeList = lesseeRepository.GetLessees();
                    foreach (LesseeDTO lessee in lesseeList)
                    {
                        if (lessee.UId == user.UId)
                        {
                            lesseeRepository.DeleteLessee(user.UId);
                        }
                    }
                    switch(newUser.RId)
                    {
                        case 1:
                            AdminDTO adminDTO = new AdminDTO
                            {
                                AdId = 0,
                                UId = newUser.UId
                            };
                            adminRepository.AddAdmin(adminDTO);
                            break;
                        case 2:
                            LessorDTO lessorDTO = new LessorDTO
                            {
                                LeId = 0,
                                UId = newUser.UId
                            };
                            lessorRepository.AddLessor(lessorDTO);
                            break;
                        case 3:
                            LesseeDTO lesseeDTO = new LesseeDTO
                            {
                                LesId = 0,
                                UId = newUser.UId
                            };
                            lesseeRepository.AddLessee(lesseeDTO);
                            break;

                    }
                }
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult DeleteUser(int id)
        {
            try
            {
                IEnumerable<AdminDTO> adminList = adminRepository.GetAdmins();
                foreach(AdminDTO admin in adminList)
                {
                    if(admin.UId == id)
                    {
                        adminRepository.DeleteAdmin(id);
                    }
                }
                IEnumerable<LessorDTO> lessorList = lessorRepository.GetLessors();
                foreach (LessorDTO lessor in lessorList)
                {
                    if (lessor.UId == id)
                    {
                        lessorRepository.DeleteLessor(id);
                    }
                }
                IEnumerable<LesseeDTO> lesseeList = lesseeRepository.GetLessees();
                foreach (LesseeDTO lessee in lesseeList)
                {
                    if (lessee.UId == id)
                    {
                        lesseeRepository.DeleteLessee(id);
                    }
                }
                userRepository.DeleteUser(id);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
