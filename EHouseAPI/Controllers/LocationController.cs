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
        private readonly IHouseAddressRepository houseAddressRepository;
        public LocationController(ILocationRepository locationRepository, IHouseAddressRepository houseAddressRepository)
        {
            this.locationRepository = locationRepository;
            this.houseAddressRepository = houseAddressRepository;
        }
        [HttpGet("GetLocations")]
        public async Task<IActionResult> GetLocations()
        {
            return Ok(locationRepository.GetLocations());
        }
        [HttpGet("GetLocationsByHouseRentId")]
        public async Task<IActionResult> GetLocationsByHouseRentId(int HoId)
        {
            List<HouseAddressDTO> houseAddressDTOList = new List<HouseAddressDTO>();
            List<LocationDTO> locationDTOList = new List<LocationDTO>();
            houseAddressDTOList = houseAddressRepository.GetHouseAddressesByHouseRentId(HoId);
            foreach(var r in houseAddressDTOList)
            {
                locationDTOList.Add(locationRepository.GetLocationByLocationId(r.Location_Id));
            }
            return Ok(locationDTOList);
        }
        [HttpPost("AddLocation")]
        public async Task<IActionResult> AddLocation(LocationDTO location, int HoId)
        {
            try
            {
                locationRepository.AddLocation(location);
                LocationDTO locationDTO = new LocationDTO();
                locationDTO = locationRepository.GetLastLocation();
                HouseAddressDTO houseAddressDTO = new HouseAddressDTO
                {
                    House_Id = HoId,
                    Location_Id = locationDTO.LId
                };
                houseAddressRepository.AddHouseAddress(houseAddressDTO);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
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
                houseAddressRepository.DeleteHouseAddressWithLocationId(id);
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
