using DataAccess.DTO;
using EHouseAPI.Filter;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace EHouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : Controller
    {
        private readonly ILocationRepository locationRepository;
        public LocationController(ILocationRepository locationRepository)
        {
            this.locationRepository = locationRepository;
        }
        [AuthorizationFilter]
        [HttpGet("GetLocations")]
        public async Task<IActionResult> GetLocations()
        {
            return Ok(locationRepository.GetLocations());
        }
        [AuthorizationFilter]
        [HttpPost("AddLocation")]
        public async Task<IActionResult> AddLocation(LocationDTO location)
        {
            try
            {
                locationRepository.AddLocation(location);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [AuthorizationFilter]
        [HttpPut("UpdateLocation")]
        public async Task<IActionResult> UpdateLocation(LocationDTO location)
        {
            try
            {
                locationRepository.UpdateLocation(location);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteLocation(int id)
        {
            try
            {
                locationRepository.DeleteLocation(id);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
