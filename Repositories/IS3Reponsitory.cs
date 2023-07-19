using Amazon.S3.Model;
using BusinessObjects.Models;
using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IS3Reponsitory
    {
        Task<S3ObjectDTO> UploadFileAsync(S3Obj s3Object, AwsCredentials awsCredentials);
    }
}
