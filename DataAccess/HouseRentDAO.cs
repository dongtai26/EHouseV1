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
        public List<HouseRent> GetHouseRentsByName(string houseRentName)
        {
            var ListHouse = new List<HouseRent>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListHouse = context.HouseRents.Where(x => x.HouseRentName.Contains(houseRentName)).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListHouse;
        }
        public List<HouseRent> GetHouseRentsByDetail(string detail)
        {
            var ListHouse = new List<HouseRent>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListHouse = context.HouseRents.Where(x => x.Detail.Contains(detail)).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListHouse;
        }
        public List<HouseRent> GetHouseRentsByAreaRange(float minArea, float maxArea)
        {
            var ListHouse = new List<HouseRent>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListHouse = context.HouseRents.Where(x => minArea <= x.Area && x.Area <= maxArea).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListHouse;
        }
        public List<HouseRent> GetHouseRentsByRentPriceRange(float minRentPrice, float maxRentPrice)
        {
            var ListHouse = new List<HouseRent>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListHouse = context.HouseRents.Where(x => minRentPrice <= x.RentPrice && x.Area <= maxRentPrice).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListHouse;
        }
        public List<HouseRent> GetHouseRentsByAirConditioning(bool airConditioning)
        {
            var ListHouse = new List<HouseRent>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListHouse = context.HouseRents.Where(x => x.AirConditioning == airConditioning).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListHouse;
        }
        public List<HouseRent> GetHouseRentsByWaterHeater(bool waterHeater)
        {
            var ListHouse = new List<HouseRent>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListHouse = context.HouseRents.Where(x => x.WaterHeater == waterHeater).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListHouse;
        }
        public List<HouseRent> GetHouseRentsByWifi(bool wifi)
        {
            var ListHouse = new List<HouseRent>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListHouse = context.HouseRents.Where(x => x.Wifi == wifi).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListHouse;
        }
        public List<HouseRent> GetHouseRentsByWashingMachine(bool washingMachine)
        {
            var ListHouse = new List<HouseRent>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListHouse = context.HouseRents.Where(x => x.WashingMachine == washingMachine).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListHouse;
        }
        public List<HouseRent> GetHouseRentsByParking(bool parking)
        {
            var ListHouse = new List<HouseRent>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListHouse = context.HouseRents.Where(x => x.Parking == parking).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListHouse;
        }
        public List<HouseRent> GetHouseRentsByRefrigerator(bool refrigerator)
        {
            var ListHouse = new List<HouseRent>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListHouse = context.HouseRents.Where(x => x.Refrigerator == refrigerator).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListHouse;
        }
        public List<HouseRent> GetHouseRentsByKitchen(bool kitchen)
        {
            var ListHouse = new List<HouseRent>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListHouse = context.HouseRents.Where(x => x.Kitchen == kitchen).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListHouse;
        }
        public List<HouseRent> GetHouseRentsByHouseStatus(bool houseStatus)
        {
            var ListHouse = new List<HouseRent>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListHouse = context.HouseRents.Where(x => x.HouseStatus == houseStatus).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListHouse;
        }
        public List<HouseRent> GetHouseRentsByBed(int bed)
        {
            var ListHouse = new List<HouseRent>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListHouse = context.HouseRents.Where(x => x.Bed == bed).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListHouse;
        }
        public List<HouseRent> GetHouseRentsByRestroom(int restroom)
        {
            var ListHouse = new List<HouseRent>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListHouse = context.HouseRents.Where(x => x.Restroom == restroom).ToList();
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
        public HouseRent GetHouseRentById(int id)
        {
            HouseRent houseRent = new HouseRent();
            try
            {
                var db = new AppDbContext();
                houseRent = db.HouseRents.SingleOrDefault(x => x.HoId == id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return houseRent;
        }
    }
}
