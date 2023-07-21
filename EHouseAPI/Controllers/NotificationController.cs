using EHouseAPI.Filter;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace EHouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : Controller
    {
        private readonly INotificationRepository notificationRepository;
        private readonly ICommentRepository commentRepository;
        private readonly IPostRepository postRepository;
        public NotificationController(INotificationRepository notificationRepository, ICommentRepository commentRepository, IPostRepository postRepository)
        {
            this.notificationRepository = notificationRepository;
            this.commentRepository = commentRepository;
            this.postRepository = postRepository;
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetNotifications")]
        public async Task<IActionResult> GetNotifications()
        {
            return Ok(notificationRepository.GetNotifications());
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetCommentByIdInNotification/{id}")]
        public async Task<IActionResult> GetCommentByIdInNotification(int id)
        {
            return Ok(commentRepository.GetCommentById(id));
        }
        /*[AuthorizationFilter]*/
        [HttpGet("GetPostByIdInNotification/{id}")]
        public async Task<IActionResult> GetPostByIdInNotification(int id)
        {
            return Ok(postRepository.GetPostById(id));
        }
    }
}
