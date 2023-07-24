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
    public class PostRepository : IPostRepository
    {
        PostDAO postDAO = new PostDAO();
        public void CreatePost(PostDTO postDTO)
        {
            postDAO.CreatePost(Mapper.mapToEntity(postDTO));
        }

        public void DeletePost(int id)
        {
            postDAO.DeletePost(id);
        }

        public void EditPost(PostDTO postDTO)
        {
            postDAO.EditPost(Mapper.mapToEntity(postDTO));
        }

        public List<PostDTO> GetPosts()
        {
            return postDAO.GetPosts().Select(m => Mapper.mapToDTO(m)).ToList();
        }
        public PostDTO GetPostById(int id)
        {
            return Mapper.mapToDTO(postDAO.GetPostById(id));
        }
    }
}
