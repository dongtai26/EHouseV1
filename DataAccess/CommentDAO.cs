using BusinessObjects.Data;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CommentDAO
    {
        public List<Comment> GetComments()
        {
            var ListComment = new List<Comment>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListComment = context.Comments.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListComment;
        }
        public Comment GetCommentById(int id)
        {
            Comment comment = new Comment();
            try
            {
                using (var context = new AppDbContext())
                {
                    comment = context.Comments.SingleOrDefault(x => x.CId == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return comment;
        }
        public List<Comment> GetCommentByPostId(int id)
        {
            var  ListComment = new List<Comment>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListComment = context.Comments.Where(x => x.PId == id).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListComment;
        }
        public void CreateComment (Comment comment)
        {
            try
            {
                var db = new AppDbContext();
                db.Comments.Add(comment);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteComment(int id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var cDelete = context.Comments.SingleOrDefault(x => x.CId == id);
                    context.Comments.Remove(cDelete);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void EditComment(Comment comment)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    context.Entry<Comment>(comment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public Comment GetLastComment()
        {
            Comment comment = new Comment();
            var ListComment = new List<Comment>();
            try
            {
                var db = new AppDbContext();
                comment = db.Comments.OrderBy(m => m.CId).Last();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return comment;
        }
    }
}
