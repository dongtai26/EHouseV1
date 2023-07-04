using DataAccess.DTO;
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
        [HttpGet("GetLocations")]
        public async Task<IActionResult> GetLocations()
        {
            return Ok(locationRepository.GetLocations());
        }
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
        [HttpPut("UpdateRole")]
        public async Task<IActionResult> UpdateRole(LocationDTO location)
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
