using AwsS3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwsS3.Services
{
    public interface IStorageService
    {
        Task<S3ResponseDTO> UploadFileAsync(S3Object obj, AwsCredentials awsCredentialsValues);
    }
}
