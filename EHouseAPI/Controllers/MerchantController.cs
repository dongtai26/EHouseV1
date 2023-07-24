using DataAccess.DTO;
using EHouseAPI.Filter;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace EHouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MerchantController : Controller
    {
        private readonly IMerchantRepository merchantRepository;
        public MerchantController(IMerchantRepository merchantRepository)
        {
            this.merchantRepository = merchantRepository;
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetMerchants")]
        public async Task<IActionResult> GetMerchants()
        {
            return Ok(merchantRepository.GetMerchants());
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetMerchantById")]
        public async Task<IActionResult> GetMerchantById(string id)
        {
            return Ok(merchantRepository.GetMerchantById(id));
        }
        /*[AuthorizationFilter]*/
        [HttpPost("CreateMerchant")]
        public async Task<IActionResult> CreateMerchant(MerchantDTO merchant)
        {
            try
            {
                merchantRepository.CreateMerchant(merchant);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /*[AuthorizationFilter]*/
        [HttpPut("EditMerchant")]
        public async Task<IActionResult> EditMerchant(MerchantDTO merchant)
        {
            try
            {
                merchantRepository.EditMerchant(merchant);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /*[AuthorizationFilter]*/
        [HttpDelete("DeleteMerchant")]
        public async Task<IActionResult> DeleteMerchant(string id)
        {
            try
            {
                merchantRepository.DeleteMerchant(id);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
