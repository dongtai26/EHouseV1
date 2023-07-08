using BusinessObjects.Data;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class HouseRentDAO
    {
        public List<HouseRent> GetHouseRents()
        {
            var ListHouse = new List<HouseRent>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListHouse = context.HouseRents.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListHouse;
        }
        public List<HouseRent> GetHouseRentsByLessorId(int id)
        {
            var ListHouse = new List<HouseRent>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListHouse = context.HouseRents.Where(x => x.LeId == id).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListHouse;
        }
        public void AddHouseRent(HouseRent houseRent)
        {
            try
            {
                var db = new AppDbContext();
                db.HouseRents.Add(houseRent);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void UpdateHouseRent(HouseRent houseRent)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    context.Entry<HouseRent>(houseRent).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteHouseRent(int id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var rDelete = context.HouseRents.SingleOrDefault(x => x.HoId == id);
                    context.HouseRents.Remove(rDelete);
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
