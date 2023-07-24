using DataAccess.DTO;
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
        /*[AuthorizationFilter]
        [Authorize(PostImages = "Lessor, Admin, Lessee")]*/
        [HttpGet("GetPostImages")]
        public async Task<IActionResult> GetPostImages()
        {
            return Ok(postImageRepository.GetPostImages());
        }
        /*[AuthorizationFilter]
        [Authorize(PostImages = "Admin")]*/
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
        /*[AuthorizationFilter]
        [Authorize(PostImages = "Admin")]*/
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
        /*[AuthorizationFilter]
        [Authorize(PostImages = "Admin")]*/
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
