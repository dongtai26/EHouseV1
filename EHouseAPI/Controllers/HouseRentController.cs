using DataAccess.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace EHouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HouseRentController : Controller
    {
        private readonly IHouseRentRepository houseRentRepository;
        private readonly IHouseAddressRepository houseAddressRepository;
        public HouseRentController(IHouseRentRepository houseRentRepository, IHouseAddressRepository houseAddressRepository)
        {
            this.houseRentRepository = houseRentRepository;
            this.houseAddressRepository = houseAddressRepository;
        }
        [HttpGet("GetHouseRents")]
        public async Task<IActionResult> GetHouseRents()
        {
            return Ok(houseRentRepository.GetHouseRents());
        }
        [HttpGet("SearchHouseRents")]
        public async Task<IActionResult> SearchHouseRents(string houseRentName)
        {
            return Ok(houseRentRepository.GetHouseRentsByName(houseRentName));
        }
        [HttpGet("GetHouseRentsByLessorId")]
        public async Task<IActionResult> GetHouseRentsByLessorId(int id)
        {
            return Ok(houseRentRepository.GetHouseRentsByLessorId(id));
        }
        [HttpGet("GetHouseRentsById")]
        public async Task<IActionResult> GetHouseRentsById(int id)
        {
            return Ok(houseRentRepository.GetHouseRentById(id));
        }
        [HttpPost("AddHouseRent")]
        public async Task<IActionResult> AddHouseRent(HouseRentDTO houseRent)
        {
            try
            {
                houseRentRepository.AddHouseRent(houseRent);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpPut("UpdateHouseRent")]
        public async Task<IActionResult> UpdateHouseRent(HouseRentDTO houseRent)
        {
            try
            {
                houseRentRepository.UpdateHouseRent(houseRent);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteHouseRent(int id)
        {
            try
            {
                houseAddressRepository.DeleteHouseAddressWithHouseId(id);
                houseRentRepository.DeleteHouseRent(id);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
