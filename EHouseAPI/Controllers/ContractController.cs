using DataAccess.DTO;
using EHouseAPI.Filter;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace EHouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractController : Controller
    {
        private readonly IContractRepository contractRepository;
        public ContractController(IContractRepository contractRepository)
        {
            this.contractRepository = contractRepository;
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetContracts")]
        public async Task<IActionResult> GetContracts()
        {
            return Ok(contractRepository.GetContracts());
        }
        /*[AuthorizationFilter]*/
        [HttpPost("AddContract")]
        public async Task<IActionResult> AddContract(ContractDTO contract)
        {
            try
            {
                contractRepository.AddContract(contract);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /*[AuthorizationFilter]*/
        [HttpPut("UpdateContract")]
        public async Task<IActionResult> UpdateContract(ContractDTO contract)
        {
            try
            {
                contractRepository.UpdateContract(contract);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /*[AuthorizationFilter]*/
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteContract(int id)
        {
            try
            {
                contractRepository.DeleteContract(id);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
