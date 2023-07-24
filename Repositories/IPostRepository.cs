using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IPostRepository
    {
        List<PostDTO> GetPosts();
        PostDTO GetPostById(int id);
        void CreatePost(PostDTO postDTO);
        void EditPost(PostDTO postDTO);
        void DeletePost(int id);
    }
}
