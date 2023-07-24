using BusinessObjects.Data;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PostDAO
    {
        public List<Post> GetPosts()
        {
            var listPost = new List<Post>();
            try
            {
                using (var context = new AppDbContext())
                {
                    listPost = context.Posts.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return listPost;
        }
        public Post GetPostById (int id)
        {
            Post post = new Post();
            try
            {
                using (var context = new AppDbContext())
                {
                    post = context.Posts.SingleOrDefault(x => x.PId == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return post;
        }
        public void CreatePost(Post post)
        {
            try
            {
                var db = new AppDbContext();
                db.Posts.Add(post);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void EditPost (Post post)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    context.Entry<Post>(post).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            };
        }
        public void DeletePost(int id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var rDelete = context.Posts.SingleOrDefault(x => x.PId == id);
                    context.Posts.Remove(rDelete);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
