using DataAccess.DTO;
using EHouseAPI.Filter;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace EHouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : Controller
    {
        private readonly IPostRepository postRepository;
        public PostController(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetPosts")]
        public async Task<IActionResult> GetPosts()
        {
            return Ok(postRepository.GetPosts());
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetPostByid/{id}")]
        public async Task<IActionResult> GetPostById(int id)
        {
            return Ok(postRepository.GetPostById(id));
        }
        /*[AuthorizationFilter]*/
        [HttpPost("CreatePost")]
        public async Task<IActionResult> CreatePost(PostDTO post)
        {
            try
            {
                postRepository.CreatePost(post);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /*[AuthorizationFilter]*/
        [HttpPut("EditPost")]
        public async Task<IActionResult> EditPost(PostDTO post)
        {
            try
            {
                postRepository.EditPost(post);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /*[AuthorizationFilter]
        [Authorize(Roles = "Admin")]*/
        [HttpDelete("DeletePost/{id}")]
        public async Task<IActionResult> DeletePost (int id)
        {
            try
            {
                postRepository.DeletePost(id);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
