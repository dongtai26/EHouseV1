using DataAccess.DTO;
using EHouseAPI.Filter;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace EHouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : Controller
    {
        private readonly ICommentRepository commentRepository;
        private readonly IPostRepository postRepository;
        public CommentController(ICommentRepository commentRepository, IPostRepository postRepository)
        {
            this.commentRepository = commentRepository;
            this.postRepository = postRepository;
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetComments")]
        public async Task<IActionResult> GetComments()
        {
            return Ok(commentRepository.GetComments());
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetCommentById/{id}")]
        public async Task<IActionResult> getCommentById(int id)
        {
            return Ok(commentRepository.GetCommentById(id));
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetCommentByPostId/{id}")]
        public async Task<IActionResult> GetCommentByPostId(int id)
        {
            return Ok(commentRepository.GetCommentByPostId(id));
        }
        /*[AuthorizationFilter]*/
        [HttpPost("CreateComment")]
        public async Task<IActionResult> CreateComment (CommentDTO comment)
        {
            try
            {
                commentRepository.CreateComment(comment);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /*[AuthorizationFilter]*/
        [HttpPut("EditComment")]
        public async Task<IActionResult> EditComment(CommentDTO comment)
        {
            try
            {
                commentRepository.EditComment(comment);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /*[AuthorizationFilter]
        [Authorize(Roles = "Admin")]*/
        [HttpDelete("DeleteCommnet/{id}")]
        public async Task<IActionResult> DeleteComment (int id)
        {
            try
            {
                commentRepository.DeleteComment(id);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
