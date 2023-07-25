using AwsS3.Models;
using AwsS3.Services;
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
    public class HouseImageController : ControllerBase
    {
        private readonly IHouseImageRepository houseImageRepository;
        private readonly IStorageService storageService;
        private readonly IConfiguration config;
        public HouseImageController(IHouseImageRepository houseImageRepository, IStorageService storageService, IConfiguration config)
        {
            this.houseImageRepository = houseImageRepository;
            this.storageService = storageService;
            this.config = config;
        }
        [AuthorizationFilter]
        /*[Authorize(Roles = "Lessor")]*/
        [HttpGet("GetHouseImages")]
        public async Task<IActionResult> GetHouseImages()
        {
            return Ok(houseImageRepository.GetHouseImages());
        }
        [AuthorizationFilter]
        /*[Authorize(Roles = "Lessor")]*/
        [HttpGet("GetHouseImageByHoId/{id}")]
        public async Task<IActionResult> GetHouseImageByHoId(int id)
        {
            return Ok(houseImageRepository.GetHouseImageByHoId(id));
        }
        [AuthorizationFilter]
        /*[Authorize(Roles = "Lessor")]*/
        [HttpPost("AddHouseImage")]
        public async Task<IActionResult> AddHouseImage(HouseImageDTO houseImage)
        {
            try
            {
                houseImageRepository.AddHouseImage(houseImage);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        /*        [HttpPost("AddHouseImageWithLink")]
                public async Task<IActionResult> AddHouseImageWithLink(IFormFile file, HouseImageDTO houseImage)
                {
                    try
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
                            AccessKey = config["AwsConfiguration:AWSAccessKey"],
                            SecretKey = config["AwsConfiguration:AWSSecretKey"]
                        };

                        var result = await storageService.UploadFileAsync(s3Obj, cred);
                        var url = $"https://ehouse.s3.ap-southeast-2.amazonaws.com/{docName}";
                        houseImage.HouseImageCode = url;
                        houseImageRepository.AddHouseImage(houseImage);
                        return Ok("SUCCESS");
                    }
                    catch (Exception e)
                    {
                        return BadRequest(e.Message);
                    }
                }*/
        [AuthorizationFilter]
        /*[Authorize(Roles = "Lessor")]*/
        [HttpPut("UpdateHouseImage")]
        public async Task<IActionResult> UpdateHouseImage(HouseImageDTO houseImage)
        {
            try
            {
                houseImageRepository.UpdateHouseImage(houseImage);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        [AuthorizationFilter]
        /*[Authorize(Roles = "Lessor")]*/
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteHouseImage(int id)
        {
            try
            {
                houseImageRepository.DeleteHouseImage(id);
                return Ok("SUCCESS");
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
