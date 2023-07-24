using BusinessObjects.Data;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class PostImageDAO
    {
        public List<PostImage> GetPostImages()
        {
            var ListUser = new List<PostImage>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListUser = context.PostImages.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListUser;
        }
        public void AddPostImage(PostImage postImage)
        {
            try
            {
                var db = new AppDbContext();
                db.PostImages.Add(postImage);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void UpdatePostImage(PostImage postImage)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    context.Entry<PostImage>(postImage).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeletePostImage(int id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var rDelete = context.PostImages.SingleOrDefault(x => x.PIId == id);
                    context.PostImages.Remove(rDelete);
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
