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
        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
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
                userRepository.AddUser(user);
                return Ok("Success");
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
                userRepository.UpdateUser(user);
                return Ok("Success");
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
