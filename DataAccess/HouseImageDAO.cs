using BusinessObjects.Data;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class HouseImageDAO
    {
        public List<HouseImage> GetHouseImages()
        {
            var ListUser = new List<HouseImage>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListUser = context.HouseImages.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListUser;
        }
        public List<HouseImage> GetHouseImageById(int id)
        {
            var ListImage = new List<HouseImage>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListImage = context.HouseImages.Where(m => m.HoId == id).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListImage;
        }
        public void AddHouseImage(HouseImage houseImage)
        {
            try
            {
                var db = new AppDbContext();
                db.HouseImages.Add(houseImage);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void UpdateHouseImage(HouseImage houseImage)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    context.Entry<HouseImage>(houseImage).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteHouseImage(int id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var rDelete = context.HouseImages.SingleOrDefault(x => x.HIId == id);
                    context.HouseImages.Remove(rDelete);
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
