using DataAccess;
using DataAccess.DTO;
using DataAccess.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class PostImageRepository : IPostImageRepository
    {
        PostImageDAO postImageDAO = new PostImageDAO();
        public void AddPostImage(PostImageDTO postImageDTO)
        {
            postImageDAO.AddPostImage(Mapper.mapToEntity(postImageDTO));
        }

        public void DeletePostImage(int id)
        {
            postImageDAO.DeletePostImage(id);
        }

        public List<PostImageDTO> GetHouseImageByPostId(int id)
        {
            return postImageDAO.GetHouseImageByPostId(id).Select(m => Mapper.mapToDTO(m)).ToList();
        }

        public List<PostImageDTO> GetPostImages()
        {
            return postImageDAO.GetPostImages().Select(m => Mapper.mapToDTO(m)).ToList();
        }

        public void UpdatePostImage(PostImageDTO postImageDTO)
        {
            postImageDAO.UpdatePostImage(Mapper.mapToEntity(postImageDTO));
        }
    }
}
