using Amazon.S3;
using Amazon.S3.Model;
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
        private readonly IAmazonS3 amazon3;
        private readonly ILogger<FileController> logger;
        private readonly IS3Reponsitory iS3Reponsitory;
        private readonly IConfiguration configuration;
        public FileController (IAmazonS3 amazonS3, IS3Reponsitory iS3Reponsitory, ILogger<FileController> logger, IConfiguration configuration)
        {
            this.amazon3 = amazonS3;
            this.iS3Reponsitory = iS3Reponsitory;
            this.logger = logger;
            this.configuration = configuration;
        }
        [HttpPost("UploadFile")]
        public async Task<IActionResult> UploadFileAsync(IFormFile file)
        {
            await using var memoryStr = new MemoryStream();
            await file.CopyToAsync(memoryStr);

            var fileExt = Path.GetExtension(file.Name);
            var objName = $"{Guid.NewGuid()}.{fileExt}";

            var s3Obj = new S3Obj()
            {
                BucketName = "ehouse",
                InputStream = memoryStr,
                Name = objName,
            };

            var cred = new AwsCredentials()
            {
                AwsKey = this.configuration["AwsConfiguration:AWSAccessKey"],
                AwsSecretKey = this.configuration["AwsConfiguration:AWSSecretKey"],
            };
            var result = await this.iS3Reponsitory.UploadFileAsync(s3Obj, cred);
            return Ok(result);
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
