using DataAccess.DTO;
using EHouseAPI.Filter;
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
/*        private readonly IHouseAddressRepository houseAddressRepository;*/
        public HouseRentController(IHouseRentRepository houseRentRepository)
        {
            this.houseRentRepository = houseRentRepository;
/*            this.houseAddressRepository = houseAddressRepository;*/
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetHouseRents")]
        public async Task<IActionResult> GetHouseRents()
        {
            return Ok(houseRentRepository.GetHouseRents());
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetAddress")]
        public async Task<IActionResult> GetAddress()
        {
            return Ok(houseRentRepository.GetAddress());
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetAddressHouseRentById")]
        public async Task<IActionResult> GetAddressHouseRentById(int id)
        {
            return Ok(houseRentRepository.GetAddressHouseRentById(id));
        }
        /*[AuthorizationFilter]*/
        [HttpGet("SearchHouseRents")]
        public async Task<IActionResult> SearchHouseRents(string houseRentName)
        {
            return Ok(houseRentRepository.GetHouseRentsByName(houseRentName));
        }
        /*[AuthorizationFilter]*/
        [HttpGet("SearchHouseRentsDetail")]
        public async Task<IActionResult> SearchHouseRentsDetail(string detail)
        {
            return Ok(houseRentRepository.GetHouseRentsByDetail(detail));
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetHouseRentsByLessorId/{id}")]
        public async Task<IActionResult> GetHouseRentsByLessorId(int id)
        {
            return Ok(houseRentRepository.GetHouseRentsByLessorId(id));
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetHouseRentsById/{id}")]
        public async Task<IActionResult> GetHouseRentsById(int id)
        {
            return Ok(houseRentRepository.GetHouseRentById(id));
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetHouseRentsByAreaRange")]
        public async Task<IActionResult> GetHouseRentsByAreaRange(float minArea, float maxArea)
        {
            return Ok(houseRentRepository.GetHouseRentsByAreaRange(minArea, maxArea));
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetHouseRentsByRentPriceRange")]
        public async Task<IActionResult> GetHouseRentsByRentPriceRange(float minRentPrice, float maxRentPrice)
        {
            return Ok(houseRentRepository.GetHouseRentsByRentPriceRange(minRentPrice, maxRentPrice));
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetHouseRentsByAirConditioning")]
        public async Task<IActionResult> GetHouseRentsByAirConditioning(bool airConditioning)
        {
            return Ok(houseRentRepository.GetHouseRentsByAirConditioning(airConditioning));
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetHouseRentsByWaterHeater")]
        public async Task<IActionResult> GetHouseRentsByWaterHeater(bool waterHeater)
        {
            return Ok(houseRentRepository.GetHouseRentsByWaterHeater(waterHeater));
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetHouseRentsByWifi")]
        public async Task<IActionResult> GetHouseRentsByWifi(bool wifi)
        {
            return Ok(houseRentRepository.GetHouseRentsByWifi(wifi));
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetHouseRentsByWashingMachine")]
        public async Task<IActionResult> GetHouseRentsByWashingMachine(bool washingMachine)
        {
            return Ok(houseRentRepository.GetHouseRentsByWashingMachine(washingMachine));
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetHouseRentsByParking")]
        public async Task<IActionResult> GetHouseRentsByParking(bool parking)
        {
            return Ok(houseRentRepository.GetHouseRentsByParking(parking));
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetHouseRentsByRefrigerator")]
        public async Task<IActionResult> GetHouseRentsByRefrigerator(bool refrigerator)
        {
            return Ok(houseRentRepository.GetHouseRentsByRefrigerator(refrigerator));
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetHouseRentsByKitchen")]
        public async Task<IActionResult> GetHouseRentsByKitchen(bool kitchen)
        {
            return Ok(houseRentRepository.GetHouseRentsByKitchen(kitchen));
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetHouseRentsByHouseStatus")]
        public async Task<IActionResult> GetHouseRentsByHouseStatus(bool houseStatus)
        {
            return Ok(houseRentRepository.GetHouseRentsByHouseStatus(houseStatus));
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetHouseRentsByBed")]
        public async Task<IActionResult> GetHouseRentsByBed(int bed)
        {
            return Ok(houseRentRepository.GetHouseRentsByBed(bed));
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetHouseRentsByRestroom")]
        public async Task<IActionResult> GetHouseRentsByRestroom(int restroom)
        {
            return Ok(houseRentRepository.GetHouseRentsByRestroom(restroom));
        }
        /*[AuthorizationFilter]*/
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
        /*[AuthorizationFilter]*/
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
        /*[AuthorizationFilter]*/
        [HttpPut("UpdateAddress")]
        public async Task<IActionResult> UpdateAddress(HouseRentAddressDTO houseRentAddress)
        {
            try
            {
                houseRentRepository.UpdateAddress(houseRentAddress);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /*[AuthorizationFilter]*/
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteHouseRent(int id)
        {
            try
            {
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
