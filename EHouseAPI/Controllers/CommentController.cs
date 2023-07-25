using DataAccess.DTO;
using EHouseAPI.Filter;
using Microsoft.AspNetCore.Authorization;
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
        private readonly INotificationRepository notificationRepository;
        private readonly IUserRepository userRepository;
        public CommentController(ICommentRepository commentRepository, IPostRepository postRepository, INotificationRepository notificationRepository, IUserRepository userRepository)
        {
            this.commentRepository = commentRepository;
            this.postRepository = postRepository;
            this.notificationRepository = notificationRepository;
            this.userRepository = userRepository;
        }
        [AuthorizationFilter]
        /*[Authorize(Roles = "Admin")]*/
        [HttpGet("GetComments")]
        public async Task<IActionResult> GetComments()
        {
            return Ok(commentRepository.GetComments());
        }
        [AuthorizationFilter]
        /*[Authorize(Roles = "Admin")]*/
        [HttpGet("GetCommentById/{id}")]
        public async Task<IActionResult> getCommentById(int id)
        {
            return Ok(commentRepository.GetCommentById(id));
        }
        [AuthorizationFilter]
        /*[Authorize(Roles = "Admin")]*//*[AuthorizationFilter]*/
        [HttpGet("GetCommentByPostId/{id}")]
        public async Task<IActionResult> GetCommentByPostId(int id)
        {
            return Ok(commentRepository.GetCommentByPostId(id));
        }
        [AuthorizationFilter]
        /*[Authorize(Roles = "Admin")]*/
        [HttpGet("GetLastComment")]
        public async Task<IActionResult> GetLastComment()
        {
            return Ok(commentRepository.GetLastComment());
        }
        [AuthorizationFilter]
        /*[Authorize(Roles = "Admin")]*/
        [HttpPost("CreateComment")]
        public async Task<IActionResult> CreateComment (CommentDTO comment)
        {
            try
            {
                commentRepository.CreateComment(comment);
                CommentDTO lastComment = commentRepository.GetLastComment();
                UserDTO user = userRepository.GetUserById(lastComment.UId);
                NotificationDTO notificationDTO = new NotificationDTO
                {
                    NoId = 0,
                    NoContent = $"{user.FullName} đã bình luận vào bài đăng của bạn" ,
                    NoName = "Một thông báo mới cho bạn",
                    PId = lastComment.PId,
                    UId = lastComment.UId,
                    CId = lastComment.CId
                };
                notificationRepository.CreateNotification(notificationDTO);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [AuthorizationFilter]
        /*[Authorize(Roles = "Admin")]*/
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
        [AuthorizationFilter]
        /*[Authorize(Roles = "Admin")]*/
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
