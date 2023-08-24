using Azure;
using Azure.Communication.Email;
using DataAccess.DTO;
using EHouseAPI.Filter;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;
using Security;
using System.Security.Claims;

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
        private readonly ITokenManager tokenManager;
        private readonly IHttpContextAccessor httpContextAccessor;
        public UserController(IUserRepository userRepository, IAdminRepository adminRepository, ILesseeRepository lesseeRepository, ILessorRepository lessorRepository,
            ITokenManager tokenManager, IHttpContextAccessor httpContextAccessor)
        {
            this.userRepository = userRepository;
            this.adminRepository = adminRepository;
            this.lesseeRepository = lesseeRepository;
            this.lessorRepository = lessorRepository;
            this.tokenManager = tokenManager;
            this.httpContextAccessor = httpContextAccessor;
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetUsers")]
        public async Task<IActionResult> GetUsers()
        {
            return Ok(userRepository.GetUsers());
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetUserById/{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            return Ok(userRepository.GetUserById(id));
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetRoleByUserId/{id}")]
        public async Task<IActionResult> GetRoleIdByUserId(int id)
        {
            try
            {
                var UserDTO = userRepository.GetUserById(id);
                if (UserDTO.RId == 1)
                {
                    return Ok(adminRepository.GetAdminById(id));
                }
                else if (UserDTO.RId == 2)
                {
                    return Ok(lessorRepository.GetLessorById(id));
                }
                else if (UserDTO.RId == 3)
                {
                    return Ok(lesseeRepository.GetLesseeById(id));
                }
            }
            catch (Exception e)
            {
                return Ok("Người dùng không tồn tại");
            }
            return null;
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetAdminByUserId/{id}")]
        public async Task<IActionResult> GetAdminByUserId(int id)
        {
            return Ok(adminRepository.GetAdminById(id));
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetLessorByUserId/{id}")]
        public async Task<IActionResult> GetLessorByUserId(int id)
        {
            return Ok(lessorRepository.GetLessorById(id));
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetLesseeByUserId/{id}")]
        public async Task<IActionResult> GetLesseeByUserId(int id)
        {
            return Ok(lesseeRepository.GetLesseeById(id));
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetUserByRoleId/{id}")]
        public async Task<IActionResult> GetUserByRoleId(int id)
        {
            return Ok(userRepository.GetUsersByRoleId(id));
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetAdminByAdminId/{id}")]
        public async Task<IActionResult> GetAdminByAdminId(int id)
        {
            AdminDTO adminDTO = adminRepository.GetAdminByAdminId(id);
            UserDTO userDTO = userRepository.GetUserById(adminDTO.UId);
            return Ok(userDTO);
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetLessorByLessorId/{id}")]
        public async Task<IActionResult> GetLessorByLessorId(int id)
        {
            LessorDTO lessorDTO = lessorRepository.GetLessorByLessorId(id);
            UserDTO userDTO = userRepository.GetUserById(lessorDTO.UId);
            return Ok(userDTO);
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetLesseeByLesseeId/{id}")]
        public async Task<IActionResult> GetLesseeByLesseeId(int id)
        {
            LesseeDTO lesseeDTO = lesseeRepository.GetLesseeByLesseeId(id);
            UserDTO userDTO = userRepository.GetUserById(lesseeDTO.UId);
            return Ok(userDTO);
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetAdmins")]
        public async Task<IActionResult> GetAdmins()
        {
            return Ok(userRepository.GetUsersByRoleId(1));
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetLessors")]
        public async Task<IActionResult> GetLessors()
        {
            return Ok(userRepository.GetUsersByRoleId(2));
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetLesseees")]
        public async Task<IActionResult> GetLesseees()
        {
            return Ok(userRepository.GetUsersByRoleId(3));
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserDTO user)
        {
            try
            {
                string msg = "";
                if(userRepository.CheckExistUsername(user))
                {
                    msg = "Tên đăng nhập đã tồn tại\n";
                }
                if(userRepository.CheckExistGmail(user))
                {
                    msg += "Gmail đã tồn tại\n";
                }
                if(userRepository.CheckExistPhoneNumber(user))
                {
                    msg += "Số điện thoại đã tồn tại\n";
                }
                if(userRepository.CheckExistCitizenIdentification(user))
                {
                    msg += "Căn cước công dân đã tồn tại";
                }
                if(userRepository.CheckExistUsername(user) == false && userRepository.CheckExistGmail(user) == false && userRepository.CheckExistPhoneNumber(user) == false && userRepository.CheckExistCitizenIdentification(user) == false)
                {
                    msg = "SUCCESS, plese verify your email";
                    user.Gmail = user.Gmail.Replace(user.Gmail, $"{user.Gmail},Unverified");
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
                    var key = new AzureKeyCredential("VDBDO5zwKZwoi2fMatge9ErkKZliDS2jd8ofI+C6aIJ+XsXtoriRZ/0Cb3NzxKlD5ARI1ue21qKyCSFQkbHlvw==");
                    var endpoint = new Uri("https://communicationserviceehouse.unitedstates.communication.azure.com");
                    var emailClient = new EmailClient(endpoint, key);
                    var sender = "donotreply@c845cb18-50c4-4a76-90b9-459b2314e925.azurecomm.net";
                    var recipient = user.Gmail.Replace(",Unverified", "");
                    var subject = "Verify Email For Ehouse System";
                    var htmlContent = $"https://ehomesystem.vercel.app/successfully?Uid={userRepository.GetLastUser().UId}";
                    EmailSendOperation emailSendOperation = await emailClient.SendAsync(
                        Azure.WaitUntil.Completed,
                        sender,
                        recipient,
                        subject,
                        htmlContent);
                    EmailSendResult statusMonitor = emailSendOperation.Value;
                }
                else
                {
                }
                return Ok(msg);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [AuthorizationFilter]
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpPut("UpdateUser")]
        public async Task<IActionResult> UpdateUser(UserDTO user)
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
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpPut("UpdateAvatar/{id}")]
        public async Task<IActionResult> UpdateAvatar(int id, UserAvatarDTO userAvatarDTO)
        {
            try
            {
                userRepository.UpdateAvatarForUser(id, userAvatarDTO);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
/*        [AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteUser(int id)
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
        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserDTO user)
        {
            try
            {
                UserDTO userDTO = userRepository.Login(user.Username, user.Password);
                if(!userDTO.Gmail.Contains(",Unverified")) {
                    string token = tokenManager.GenerateNewToken(userDTO);
                    if (tokenManager.GetUserValidTokenStorage(userDTO.UId) == null)
                    {
                        tokenManager.AddUserValidTokenStorage(userDTO.UId);
                    }
                    tokenManager.SaveToken(userDTO.UId, token);
                    HttpContext.Response.Cookies.Append("token", token,
                        new CookieOptions
                        {
                            Expires = DateTime.Now.AddDays(1),
                            Secure = true,
                            HttpOnly = true,
                            IsEssential = true,
                            SameSite = SameSiteMode.None
                        });
                    return Ok(new
                    {
                        token = "bearer " + token
                    });
                } else
                {
                    return Ok("Your account need to verify gmail first");
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }   
        }
        [HttpPost("VerifyEmail")]
        public async Task<IActionResult> VerifyEmail(int id)
        {
            try
            {
                UserDTO user = userRepository.GetUserById(id);
                user.Gmail = user.Gmail.Replace(",Unverified", "");
                userRepository.UpdateUser(user);
                return Ok("Verify email success");

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [AuthorizationFilter]
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("Logout")]
        public async Task<IActionResult> Logout()
        {
            try
            {
                int UId = int.Parse(httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
                tokenManager.DeleteToken(UId);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [AuthorizationFilter]
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("LoggedUser")]
        public async Task<IActionResult> LoggedUser()
        {
            try
            {
                int UId = int.Parse(httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));
                UserDTO user = userRepository.GetUsers().FirstOrDefault(m => m.UId == UId);
                return Ok(user);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost("ChangePassword")]
        public async Task<IActionResult> ChangePassword(string username, string password, string newPassword, string confirmNewPassword)
        {
            try
            {
                UserDTO user = userRepository.Login(username, password);
                if (!confirmNewPassword.Equals(newPassword)) throw new Exception("Confirm password not match with new password");
                user.Password = newPassword;
                userRepository.UpdateUser(user);
                return Ok(user);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost("ForgotPasswordRequest")]
        public async Task<IActionResult> ForgotPasswordRequest(string username, string gmail)
        {
            try
            {
                UserDTO user = userRepository.ForgotPassword(gmail, username);
                var key = new AzureKeyCredential("VDBDO5zwKZwoi2fMatge9ErkKZliDS2jd8ofI+C6aIJ+XsXtoriRZ/0Cb3NzxKlD5ARI1ue21qKyCSFQkbHlvw==");
                var endpoint = new Uri("https://communicationserviceehouse.unitedstates.communication.azure.com");
                var emailClient = new EmailClient(endpoint, key);
                var sender = "donotreply@c845cb18-50c4-4a76-90b9-459b2314e925.azurecomm.net";
                var recipient = user.Gmail;
                var subject = "Forgot password request From Ehouse System";
                var htmlContent = $"https://ehomesystem.vercel.app/pages/other-pages/forgot-pass-verify?Uid={user.UId}";
                EmailSendOperation emailSendOperation = await emailClient.SendAsync(
                    Azure.WaitUntil.Completed,
                    sender,
                    recipient,
                    subject,
                    htmlContent);
                EmailSendResult statusMonitor = emailSendOperation.Value;
                return Ok("Forgot password request success, go to your gmail to change your password");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost("ForgotPassword")]
        public async Task<IActionResult> ChangePassword(int id, string newPassword, string confirmNewPassword)
        {
            try
            {
                UserDTO user = userRepository.GetUserById(id);
                if(newPassword != confirmNewPassword)
                {
                    return Ok("New password not match with confirm new password");
                }
                else
                {
                    user.Password = newPassword;
                    userRepository.UpdateUser(user);
                    return Ok("Forgot password success");
                }
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPost("SendEmail")]
        public async Task<IActionResult> SendEmail(string subject, string htmlContent, string recipient)
        {
            try
            {
                var key = new AzureKeyCredential("VDBDO5zwKZwoi2fMatge9ErkKZliDS2jd8ofI+C6aIJ+XsXtoriRZ/0Cb3NzxKlD5ARI1ue21qKyCSFQkbHlvw==");
                var endpoint = new Uri("https://communicationserviceehouse.unitedstates.communication.azure.com");
                var emailClient = new EmailClient(endpoint, key);
                var sender = "donotreply@c845cb18-50c4-4a76-90b9-459b2314e925.azurecomm.net";
                EmailSendOperation emailSendOperation = await emailClient.SendAsync(
                    Azure.WaitUntil.Completed,
                    sender,
                    recipient,
                    subject,
                    htmlContent);
                EmailSendResult statusMonitor = emailSendOperation.Value;
                return Ok($"Email Sent. Status = {emailSendOperation.Value.Status}");

                /// Get the OperationId so that it can be used for tracking the message for troubleshooting
/*                string operationId = emailSendOperation.Id;
                Console.WriteLine($"Email operation id = {operationId}");*/
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpGet("StatisticUser")]
        public async Task<IActionResult> StatisticUser()
        {
            CountUserDTO countUserDTO = new();
            countUserDTO.totalUser = userRepository.CountTotalUser();
            countUserDTO.totalLessee = lesseeRepository.CountTotalLessee();
            countUserDTO.totalLessor = lessorRepository.CountTotalLessor();
            return Ok(countUserDTO);
        }
/*        [HttpGet("GetFuleNameAndCccd")]
        public async Task<IActionResult> GetFuleNameAndCccd(int id)
        {
            return Ok(userRepository.GetFuleNameAndCccd(id));
        }*/
    }
}
