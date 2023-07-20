using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICommentRepository
    {
        List<CommentDTO> GetComments();
        CommentDTO GetCommentById(int id);
        CommentDTO GetCommentByPostId(int id);
        void CreateComment(CommentDTO commentDTO);
        void EditComment(CommentDTO commentDTO);
        void DeleteComment(int id); 
    }
}
