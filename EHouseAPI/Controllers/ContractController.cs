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
    public class ContractController : Controller
    {
        private readonly IContractRepository contractRepository;
        private readonly IHouseRentRepository houseRentRepository;
        private readonly IUserRepository userRepository;
        private readonly ILesseeRepository lesseeRepository;
        private readonly ILessorRepository lessorRepository;
        public ContractController(IContractRepository contractRepository, IHouseRentRepository houseRentRepository, IUserRepository userRepository, ILesseeRepository lesseeRepository, ILessorRepository lessorRepository)
        {
            this.contractRepository = contractRepository;
            this.houseRentRepository = houseRentRepository;
            this.userRepository = userRepository;
            this.lesseeRepository = lesseeRepository;
            this.lessorRepository = lessorRepository;
        }
        [AuthorizationFilter]
        /*[Authorize(Roles = "Admin")]*/
        [HttpGet("GetContracts")]
        public async Task<IActionResult> GetContracts()
        {
            return Ok(contractRepository.GetContracts());
        }
        [AuthorizationFilter]
        /*[Authorize(Roles = "Admin")]*/
        [HttpGet("GetContractsById/{id}")]
        public async Task<IActionResult> GetContractsById(int id)
        {
            return Ok(contractRepository.GetContractById(id));
        }
        [AuthorizationFilter]
        /*[Authorize(Roles = "Admin")]*/
        [HttpGet("GetInformationContractById/{id}")]
        public async Task<IActionResult> GetInformationContractById(int id)
        {
            ContractDTO contractDTO = contractRepository.GetContractById(id);
            HouseRentDTO houseRentDTO = houseRentRepository.GetHouseRentById(contractDTO.HoId);
            LesseeDTO lesseeDTO = lesseeRepository.GetLesseeByLesseeId(contractDTO.LesId);
            LessorDTO lessorDTO = lessorRepository.GetLessorByLessorId(contractDTO.LeId);
            UserDTO userDTO1 = userRepository.GetUserById(lesseeDTO.UId);
            UserDTO userDTO2 = userRepository.GetUserById(lessorDTO.UId);
            ContractInfomationDTO contractInfomationDTO = new ContractInfomationDTO
            {
                ConId = id,
                HoId = houseRentDTO.HoId,
                Area = houseRentDTO.Area,
                LeId = contractDTO.LeId,
                FullName1 = userDTO2.FullName,
                CitizenIdentification1 = userDTO2.CitizenIdentification,
                LesId = contractDTO.LesId,
                FullName2 = userDTO1.FullName,
                CitizenIdentification2 = userDTO1.CitizenIdentification,
            };
            return Ok(contractInfomationDTO);
        }
        [AuthorizationFilter]
        /*[Authorize(Roles = "Admin")]*/
        [HttpGet("GetContractsByLesseeId/{id}")]
        public async Task<IActionResult> GetContractsByLesseeId(int id)
        {
            return Ok(contractRepository.GetContractByLesseeId(id));
        }
        [AuthorizationFilter]
        /*[Authorize(Roles = "Admin")]*/
        [HttpGet("GetContractsByLessorId/{id}")]
        public async Task<IActionResult> GetContractsByLessorId(int id)
        {
            return Ok(contractRepository.GetContractByLessorId(id));
        }
        [AuthorizationFilter]
        /*[Authorize(Roles = "Admin")]*/
        [HttpGet("GetContractsByAdminId/{id}")]
        public async Task<IActionResult> GetContractsByAdminId(int id)
        {
            return Ok(contractRepository.GetContractByAdminId(id));
        }
        [AuthorizationFilter]
        /*[Authorize(Roles = "Admin")]*/
        [HttpGet("GetStatusAdminId")]
        public async Task<IActionResult> GetContractByStatusAdminId(bool statusAdminId)
        {
            return Ok(contractRepository.GetContractByStatusAdminId(statusAdminId));
        }
        [AuthorizationFilter]
        /*[Authorize(Roles = "Admin")]*/
        [HttpGet("GetStatusLessorId")]
        public async Task<IActionResult> GetContractByStatusLessorId(bool statusLessorId)
        {
            return Ok(contractRepository.GetContractByStatusLessorId(statusLessorId));
        }
        [AuthorizationFilter]
        /*[Authorize(Roles = "Admin")]*/
        [HttpGet("GetContractsByLessorIdAndStutasLessorId")]
        public async Task<IActionResult> GetContractsByLessorIdAndStutasLessorId(int id, bool StatusLessorId)
        {
            return Ok(contractRepository.GetContractsByLessorIdAndStutasLessorId(id, StatusLessorId));
        }
        [AuthorizationFilter]
        /*[Authorize(Roles = "Admin")]*/
        [HttpGet("GetContractByLessorIdAndStatusLessor")]
        public async Task<IActionResult> GetContractByLessorIdAndStutasLessorId(int id, bool StatusLessorId)
        {
            return Ok(contractRepository.GetContractByLessorIdAndStutasLessorId(id, StatusLessorId));
        }
        [AuthorizationFilter]
        /*[Authorize(Roles = "Admin")]*/
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
        [AuthorizationFilter]
        /*[Authorize(Roles = "Admin")]*/
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
        [AuthorizationFilter]
        /*[Authorize(Roles = "Admin")]*/
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
        [HttpGet("CountContractByLessorId")]
        public async Task<IActionResult> CountContractByLessorId(int id)
        {
            return Ok(CountContractByLessorId(id));
        }
    }
}
