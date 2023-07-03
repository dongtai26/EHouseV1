using DataAccess.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;
using Microsoft.AspNetCore.Authorization;
using EHouseAPI.Filter;

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
        [AuthorizationFilter]
        [Authorize(Roles = "Lessor, Admin, Lessee")]
        [HttpGet("GetRoles")]
        public IActionResult GetRoles()
        {
            return Ok(roleRepository.GetRoles());
        }
        [AuthorizationFilter]
        [Authorize(Roles = "Admin")]
        [HttpPost("AddRole")]
        public IActionResult AddRole(RoleDTO role)
        {
            try
            {
                roleRepository.AddRole(role);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [AuthorizationFilter]
        [Authorize(Roles = "Admin")]
        [HttpPut("UpdateRole")]
        public IActionResult UpdateRole(RoleDTO role)
        {
            try
            {
                roleRepository.UpdateRole(role);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [AuthorizationFilter]
        [Authorize(Roles = "Admin")]
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
