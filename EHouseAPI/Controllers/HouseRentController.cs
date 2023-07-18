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
        [HttpGet("SearchHouseRentsDetail")]
        public async Task<IActionResult> SearchHouseRentsDetail(string detail)
        {
            return Ok(houseRentRepository.GetHouseRentsByDetail(detail));
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
        [HttpGet("GetHouseRentsByAreaRange")]
        public async Task<IActionResult> GetHouseRentsByAreaRange(float minArea, float maxArea)
        {
            return Ok(houseRentRepository.GetHouseRentsByAreaRange(minArea, maxArea));
        }
        [HttpGet("GetHouseRentsByRentPriceRange")]
        public async Task<IActionResult> GetHouseRentsByRentPriceRange(float minRentPrice, float maxRentPrice)
        {
            return Ok(houseRentRepository.GetHouseRentsByRentPriceRange(minRentPrice, maxRentPrice));
        }
        [HttpGet("GetHouseRentsByAirConditioning")]
        public async Task<IActionResult> GetHouseRentsByAirConditioning(bool airConditioning)
        {
            return Ok(houseRentRepository.GetHouseRentsByAirConditioning(airConditioning));
        }
        [HttpGet("GetHouseRentsByWaterHeater")]
        public async Task<IActionResult> GetHouseRentsByWaterHeater(bool waterHeater)
        {
            return Ok(houseRentRepository.GetHouseRentsByWaterHeater(waterHeater));
        }
        [HttpGet("GetHouseRentsByWifi")]
        public async Task<IActionResult> GetHouseRentsByWifi(bool wifi)
        {
            return Ok(houseRentRepository.GetHouseRentsByWifi(wifi));
        }
        [HttpGet("GetHouseRentsByWashingMachine")]
        public async Task<IActionResult> GetHouseRentsByWashingMachine(bool washingMachine)
        {
            return Ok(houseRentRepository.GetHouseRentsByWashingMachine(washingMachine));
        }
        [HttpGet("GetHouseRentsByParking")]
        public async Task<IActionResult> GetHouseRentsByParking(bool parking)
        {
            return Ok(houseRentRepository.GetHouseRentsByParking(parking));
        }
        [HttpGet("GetHouseRentsByRefrigerator")]
        public async Task<IActionResult> GetHouseRentsByRefrigerator(bool refrigerator)
        {
            return Ok(houseRentRepository.GetHouseRentsByRefrigerator(refrigerator));
        }
        [HttpGet("GetHouseRentsByKitchen")]
        public async Task<IActionResult> GetHouseRentsByKitchen(bool kitchen)
        {
            return Ok(houseRentRepository.GetHouseRentsByKitchen(kitchen));
        }
        [HttpGet("GetHouseRentsByHouseStatus")]
        public async Task<IActionResult> GetHouseRentsByHouseStatus(bool houseStatus)
        {
            return Ok(houseRentRepository.GetHouseRentsByHouseStatus(houseStatus));
        }
        [HttpGet("GetHouseRentsByBed")]
        public async Task<IActionResult> GetHouseRentsByBed(int bed)
        {
            return Ok(houseRentRepository.GetHouseRentsByBed(bed));
        }
        [HttpGet("GetHouseRentsByRestroom")]
        public async Task<IActionResult> GetHouseRentsByRestroom(int restroom)
        {
            return Ok(houseRentRepository.GetHouseRentsByRestroom(restroom));
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
