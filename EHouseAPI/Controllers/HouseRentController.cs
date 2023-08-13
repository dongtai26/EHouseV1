using DataAccess.DTO;
using EHouseAPI.Filter;
using Microsoft.AspNetCore.Authorization;
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
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetHouseRents")]
        public async Task<IActionResult> GetHouseRents()
        {
            return Ok(houseRentRepository.GetHouseRents());
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetAddress")]
        public async Task<IActionResult> GetAddress()
        {
            return Ok(houseRentRepository.GetAddress());
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetAddressHouseRentById/{id}")]
        public async Task<IActionResult> GetAddressHouseRentById(int id)
        {
            return Ok(houseRentRepository.GetAddressHouseRentById(id));
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetHouseRentsByLessorIdAndHouseStatus/{id}")]
        public async Task<IActionResult> GetHouseRentsByLessorIdAndHouseStatus(int id, bool houseStatus)
        {
            return Ok(houseRentRepository.GetHouseRentsByLessorIdAndHouseStatus(id, houseStatus));
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("SearchHouseRents/{houseRentName}")]
        public async Task<IActionResult> SearchHouseRents(string houseRentName)
        {
            return Ok(houseRentRepository.GetHouseRentsByName(houseRentName));
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetHouseRentsIdByName")]
        public async Task<IActionResult> GetHouseRentsIdByName(string houseRentName)
        {
            return Ok(houseRentRepository.GetHoidByName(houseRentName));
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("SearchHouseRentsDetail")]
        public async Task<IActionResult> SearchHouseRentsDetail(string detail)
        {
            return Ok(houseRentRepository.GetHouseRentsByDetail(detail));
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetHouseRentsByLessorId/{id}")]
        public async Task<IActionResult> GetHouseRentsByLessorId(int id)
        {
            return Ok(houseRentRepository.GetHouseRentsByLessorId(id));
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetHouseRentsById/{id}")]
        public async Task<IActionResult> GetHouseRentsById(int id)
        {
            return Ok(houseRentRepository.GetHouseRentById(id));
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetHouseRentsByAreaRange")]
        public async Task<IActionResult> GetHouseRentsByAreaRange(float minArea, float maxArea)
        {
            return Ok(houseRentRepository.GetHouseRentsByAreaRange(minArea, maxArea));
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetHouseRentsByRentPriceRange")]
        public async Task<IActionResult> GetHouseRentsByRentPriceRange(float minRentPrice, float maxRentPrice)
        {
            return Ok(houseRentRepository.GetHouseRentsByRentPriceRange(minRentPrice, maxRentPrice));
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetHouseRentsByAirConditioning")]
        public async Task<IActionResult> GetHouseRentsByAirConditioning(bool airConditioning)
        {
            return Ok(houseRentRepository.GetHouseRentsByAirConditioning(airConditioning));
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetHouseRentsByWaterHeater")]
        public async Task<IActionResult> GetHouseRentsByWaterHeater(bool waterHeater)
        {
            return Ok(houseRentRepository.GetHouseRentsByWaterHeater(waterHeater));
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetHouseRentsByWifi")]
        public async Task<IActionResult> GetHouseRentsByWifi(bool wifi)
        {
            return Ok(houseRentRepository.GetHouseRentsByWifi(wifi));
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetHouseRentsByWashingMachine")]
        public async Task<IActionResult> GetHouseRentsByWashingMachine(bool washingMachine)
        {
            return Ok(houseRentRepository.GetHouseRentsByWashingMachine(washingMachine));
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetHouseRentsByParking")]
        public async Task<IActionResult> GetHouseRentsByParking(bool parking)
        {
            return Ok(houseRentRepository.GetHouseRentsByParking(parking));
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetHouseRentsByRefrigerator")]
        public async Task<IActionResult> GetHouseRentsByRefrigerator(bool refrigerator)
        {
            return Ok(houseRentRepository.GetHouseRentsByRefrigerator(refrigerator));
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetHouseRentsByKitchen")]
        public async Task<IActionResult> GetHouseRentsByKitchen(bool kitchen)
        {
            return Ok(houseRentRepository.GetHouseRentsByKitchen(kitchen));
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetHouseRentsByHouseStatus")]
        public async Task<IActionResult> GetHouseRentsByHouseStatus(bool houseStatus)
        {
            return Ok(houseRentRepository.GetHouseRentsByHouseStatus(houseStatus));
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetHouseRentsByBed")]
        public async Task<IActionResult> GetHouseRentsByBed(int bed)
        {
            return Ok(houseRentRepository.GetHouseRentsByBed(bed));
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetHouseRentsByRestroom")]
        public async Task<IActionResult> GetHouseRentsByRestroom(int restroom)
        {
            return Ok(houseRentRepository.GetHouseRentsByRestroom(restroom));
        }
        [HttpGet("FilterHouseRent")]
        public async Task<IActionResult> FilterHouseRent(float minArea, float maxArea, float minRentPrice, float maxRentPrice, bool airConditioning, bool waterHeater, bool wifi, bool washingMachine, bool parking, bool refrigerator, bool kitchen, bool houseStatus)
        {
            return Ok(houseRentRepository.FilterHouseRent(minArea, maxArea, minRentPrice, maxRentPrice, airConditioning, waterHeater, wifi, washingMachine, parking, refrigerator, kitchen, houseStatus));
        }
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
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
        [AuthorizationFilter]
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
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
        [AuthorizationFilter]
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpPut("UpdateHouseStatus/{id}")]
        public async Task<IActionResult> UpdateStatus(int id, HouseStatusDTO houseStatussDTO)
        {
            try
            {
                houseRentRepository.UpdateStatus(id, houseStatussDTO);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [AuthorizationFilter]
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpPut("UpdateHouseAddress/{id}")]
        public async Task<IActionResult> UpdateHouseAddress(int id, HouseRentAddressDTO houseRentAddressDTO)
        {
            try
            {
                houseRentRepository.UpdateHouseAddress(id, houseRentAddressDTO);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [AuthorizationFilter]
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
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
        /*[AuthorizationFilter]*/
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("StatisticHouseRent")]
        public async Task<IActionResult> StatisticHouseRent()
        {
            CountHouseRentDTO countHouseRentDTO = new();
            countHouseRentDTO.totalHouseRent = houseRentRepository.CountTotalHouseRent();
            countHouseRentDTO.totalHouseRentAreTrue = houseRentRepository.CountTotalHouseRentByStatusAreTrue();
            countHouseRentDTO.totalHouseRentAreFalse = houseRentRepository.CountTotalHouseRentByStatusAreFalse();
            return Ok(countHouseRentDTO);
        }
    }
}
