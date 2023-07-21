using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using BusinessObjects.Models;
using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class S3Reponsitory : IS3Reponsitory
    {
        public async Task<S3ObjectDTO> UploadFileAsync(S3Obj s3Object, AwsCredentials awsCredentials)
        {
            //Add AWS credentials
            var credentials = new BasicAWSCredentials(awsCredentials.AwsKey, awsCredentials.AwsSecretKey);

            //Specify the region
            var config = new AmazonS3Config()
            {
                RegionEndpoint = Amazon.RegionEndpoint.EUWest2
            };

            var response = new S3ObjectDTO();

            try
            {
                var uploadRequest = new TransferUtilityUploadRequest()
                {
                    InputStream = s3Object.InputStream,
                    Key = s3Object.Name,
                    BucketName = s3Object.BucketName,
                    CannedACL = S3CannedACL.NoACL
                };
                //Created sn S3 client
                using var client = new AmazonS3Client(credentials, config);
                //upload utility to S3
                var tranferUtility = new TransferUtility(client);
                //We are actually uploading the file to S3
                await tranferUtility.UploadAsync(uploadRequest);

                response.StatusCode = 200;
                response.Message = $"{s3Object.Name} has been uploaded successfully!";
            }
            catch(AmazonS3Exception ex)
            {
                response.StatusCode = (int)ex.StatusCode;
                response.Message = ex.Message;
            }
            catch (Exception ex)
            {
                response.StatusCode = 500;
                response.Message = ex.Message;
            }

            return response;
        }
    }
}
