using DataAccess.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace EHouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleRepository roleRepository;
        public RoleController(IRoleRepository roleRepository)
        {
            this.roleRepository = roleRepository;
        }
        [HttpGet("GetRoles")]
        public IActionResult GetRoles()
        {
            return Ok(roleRepository.GetRoles());
        }
        [HttpPost("AddRole")]
        public IActionResult AddRole(RoleDTO role)
        {
            try
            {
                roleRepository.AddRole(role);
                return Ok("Success");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut("UpdateRole")]
        public IActionResult UpdateRole(RoleDTO role)
        {
            try
            {
                roleRepository.UpdateRole(role);
                return Ok("Success");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult DeleteRole(int id)
        {
            try
            {
                roleRepository.DeleteRole(id);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
