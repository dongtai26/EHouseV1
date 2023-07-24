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
    public class CommentRepository : ICommentRepository
    {
        CommentDAO commentDAO = new CommentDAO();
        public void CreateComment(CommentDTO commentDTO)
        {
            commentDAO.CreateComment(Mapper.mapToEntity(commentDTO));
        }

        public void DeleteComment(int id)
        {
            commentDAO.DeleteComment(id);
        }

        public CommentDTO GetCommentById(int id)
        {
            return Mapper.mapToDTO(commentDAO.GetCommentById(id));
        }

        public List<CommentDTO> GetComments()
        {
            return commentDAO.GetComments().Select(m => Mapper.mapToDTO(m)).ToList();
        }

        public void EditComment(CommentDTO commentDTO)
        {
            commentDAO.EditComment(Mapper.mapToEntity(commentDTO));
        }

        public List<CommentDTO> GetCommentByPostId(int id)
        {
            return commentDAO.GetCommentByPostId(id).Select(m => Mapper.mapToDTO(m)).ToList();
        }

        public CommentDTO GetLastComment()
        {
            return Mapper.mapToDTO(commentDAO.GetLastComment());
        }
    }
}
