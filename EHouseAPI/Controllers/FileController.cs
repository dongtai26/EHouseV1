using AwsS3.Models;
using AwsS3.Services;
using BusinessObjects.Models;
using DataAccess.DTO;
using Microsoft.AspNetCore.Mvc;
using Repositories;

namespace EHouseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : Controller
    {
        private readonly IStorageService _storageService;
        private readonly IConfiguration _config;
        private readonly ILogger<FileController> _logger;
        private readonly IHouseImageRepository _houseImageRepository;
        private readonly IPostImageRepository _postImageRepository;
        private readonly IUserRepository _userRepository;

        public FileController(
            ILogger<FileController> logger,
            IConfiguration config,
            IStorageService storageService,
            IHouseImageRepository houseImageRepository,
            IPostImageRepository postImageRepository,
            IUserRepository userRepository)
        {
            _logger = logger;
            _config = config;
            _storageService = storageService;
            _houseImageRepository = houseImageRepository;
            _postImageRepository = postImageRepository;
            _userRepository = userRepository;
        }

        [HttpPost("UploadFileForHouseRent")]
        public async Task<IActionResult> UploadFileForHouseRent(IFormFile file, int hoid)
        {
            // Process file
            await using var memoryStream = new MemoryStream();
            await file.CopyToAsync(memoryStream);

            var fileExt = Path.GetExtension(file.FileName);
            var docName = $"{Guid.NewGuid()}{fileExt}";
            // call server

            var s3Obj = new S3Object()
            {
                BucketName = "ehouse",
                InputStream = memoryStream,
                Name = docName
            };

            var cred = new AwsCredentials()
            {
                AccessKey = _config["AwsConfiguration:AWSAccessKey"],
                SecretKey = _config["AwsConfiguration:AWSSecretKey"]
            };

            var result = await _storageService.UploadFileAsync(s3Obj, cred);
            var url = $"https://ehouse.s3.ap-southeast-2.amazonaws.com/{docName}";
            HouseImageDTO houseImageDTO = new HouseImageDTO
            {
                HIId = 0,
                HouseImageCode = url,
                HoId = hoid
            };
            _houseImageRepository.AddHouseImage(houseImageDTO);
            return Ok(url);

        }
        [HttpPost("UploadFileForPost")]
        public async Task<IActionResult> UploadFileForPost(IFormFile file, int pid)
        {
            // Process file
            await using var memoryStream = new MemoryStream();
            await file.CopyToAsync(memoryStream);

            var fileExt = Path.GetExtension(file.FileName);
            var docName = $"{Guid.NewGuid()}{fileExt}";
            // call server

            var s3Obj = new S3Object()
            {
                BucketName = "ehouse",
                InputStream = memoryStream,
                Name = docName
            };

            var cred = new AwsCredentials()
            {
                AccessKey = _config["AwsConfiguration:AWSAccessKey"],
                SecretKey = _config["AwsConfiguration:AWSSecretKey"]
            };

            var result = await _storageService.UploadFileAsync(s3Obj, cred);
            var url = $"https://ehouse.s3.ap-southeast-2.amazonaws.com/{docName}";
            PostImageDTO postImageDTO = new PostImageDTO
            {
                PIId = 0,
                PostImageUrl = url,
                PostImageName = "",
                PostImageContent = "",
                PId = pid
            };
            _postImageRepository.AddPostImage(postImageDTO);
            return Ok(url);

        }
        [HttpPut("UploadAvatarforUser")]
        public async Task<IActionResult> UploadAvatarforUser(IFormFile file, int uid)
        {
            // Process file
            await using var memoryStream = new MemoryStream();
            await file.CopyToAsync(memoryStream);

            var fileExt = Path.GetExtension(file.FileName);
            var docName = $"{Guid.NewGuid()}{fileExt}";
            // call server

            var s3Obj = new S3Object()
            {
                BucketName = "ehouse",
                InputStream = memoryStream,
                Name = docName
            };

            var cred = new AwsCredentials()
            {
                AccessKey = _config["AwsConfiguration:AWSAccessKey"],
                SecretKey = _config["AwsConfiguration:AWSSecretKey"]
            };

            var result = await _storageService.UploadFileAsync(s3Obj, cred);
            var url = $"https://ehouse.s3.ap-southeast-2.amazonaws.com/{docName}";
            UserDTO userDTO = new UserDTO
            {
                UId = uid,
                FullName = "",
                Dateofbirth = DateTime.Now,
                Address = "",
                CitizenIdentification = "",
                PhoneNumber = "",
                Gender = "",
                Gmail = "",
                Avatar = url,
                Username = "",
                Password = "",
                RId = 0,
                RoleName = ""

            };
            _userRepository.UpdateAvatarForUser(userDTO);
            return Ok(url);

        }
        /*[HttpGet]
        public async Task<IActionResult> GetAllFileAsyn(string imageName)
        {
            var request = new GetObjectRequest()
            {
                BucketName = "ehouse",
                Key = imageName,
            };

            using GetObjectResponse response = await this.amazon3.GetObjectAsync(request);
            using Stream reponseStream = response.ResponseStream;
            var stream = new MemoryStream();
            await reponseStream.CopyToAsync(stream);
            stream.Position = 0;

            return new FileStreamResult(stream, response.Headers["Content-Type"])
            {
                FileDownloadName = imageName
            };
            
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteFile(string imageName)
        {
            var request = new DeleteObjectRequest()
            {
                BucketName = "ehouse",
                Key = imageName,
            };
            var response = await this.amazon3.DeleteObjectAsync(request);  
            return Ok("Delete Success!!!");
        }*/
    }
}
