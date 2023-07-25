using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IPostImageRepository
    {
        List<PostImageDTO> GetPostImages();
        List<PostImageDTO> GetHouseImageByPostId(int id);
        void AddPostImage(PostImageDTO postImageDTO);
        void UpdatePostImage(PostImageDTO pouseImageDTO);
        void DeletePostImage(int id);
    }
}
