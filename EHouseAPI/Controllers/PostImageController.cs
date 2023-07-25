using DataAccess.DTO;
using EHouseAPI.Filter;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EHouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostImageController : ControllerBase
    {
        private readonly IPostImageRepository postImageRepository;
        public PostImageController(IPostImageRepository postImageRepository)
        {
            this.postImageRepository = postImageRepository;
        }
        [AuthorizationFilter]
        [Authorize(Roles = "Lessor, Admin, Lessee")]
        [HttpGet("GetPostImages")]
        public async Task<IActionResult> GetPostImages()
        {
            return Ok(postImageRepository.GetPostImages());
        }
        [AuthorizationFilter]
        /*[Authorize(Roles = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetHouseImageByPostId/{id}")]
        public async Task<IActionResult> GetHouseImageByPostId(int id)
        {
            return Ok(postImageRepository.GetHouseImageByPostId(id));
        }
        [AuthorizationFilter]
       /* [Authorize(Roles = "Admin")]*/
        [HttpPost("AddPostImage")]
        public async Task<IActionResult> AddPostImage(PostImageDTO postImage)
        {
            try
            {
                postImageRepository.AddPostImage(postImage);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [AuthorizationFilter]
       /* [Authorize(Roles = "Admin")]*/
        [HttpPut("UpdatePostImage")]
        public async Task<IActionResult> UpdatePostImage(PostImageDTO postImage)
        {
            try
            {
                postImageRepository.UpdatePostImage(postImage);
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
        public async Task<IActionResult> DeletePostImage(int id)
        {
            try
            {
                postImageRepository.DeletePostImage(id);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
