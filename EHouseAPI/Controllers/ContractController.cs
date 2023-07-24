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
        [HttpGet("GetContractsById/{id}")]
        public async Task<IActionResult> GetContractsById(int id)
        {
            return Ok(contractRepository.GetContractById(id));
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetContractsByLesseeId/{id}")]
        public async Task<IActionResult> GetContractsByLesseeId(int id)
        {
            return Ok(contractRepository.GetContractByLesseeId(id));
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetContractsByLessorId/{id}")]
        public async Task<IActionResult> GetContractsByLessorId(int id)
        {
            return Ok(contractRepository.GetContractByLessorId(id));
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetContractsByAdminId/{id}")]
        public async Task<IActionResult> GetContractsByAdminId(int id)
        {
            return Ok(contractRepository.GetContractByAdminId(id));
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetStatusAdminId")]
        public async Task<IActionResult> GetContractByStatusAdminId(bool statusAdminId)
        {
            return Ok(contractRepository.GetContractByStatusAdminId(statusAdminId));
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetStatusLessorId")]
        public async Task<IActionResult> GetContractByStatusLessorId(bool statusLessorId)
        {
            return Ok(contractRepository.GetContractByStatusLessorId(statusLessorId));
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetContractsByLessorIdAndStutasLessorId")]
        public async Task<IActionResult> GetContractsByLessorIdAndStutasLessorId(int id, bool StatusLessorId)
        {
            return Ok(contractRepository.GetContractsByLessorIdAndStutasLessorId(id, StatusLessorId));
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetContractByLessorIdAndStatusLessor")]
        public async Task<IActionResult> GetContractByLessorIdAndStutasLessorId(int id, bool StatusLessorId)
        {
            return Ok(contractRepository.GetContractByLessorIdAndStutasLessorId(id, StatusLessorId));
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
