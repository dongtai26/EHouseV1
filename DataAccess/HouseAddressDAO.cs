using BusinessObjects.Data;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class HouseAddressDAO
    {
        public List<HouseAddress> GetHouseAddresses()
        {
            var ListHouseAddress = new List<HouseAddress>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListHouseAddress = context.HouseAddresses.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListHouseAddress;
        }
        public List<HouseAddress> GetHouseAddressesByHouseRentId(int id)
        {
            var ListHouseAddress = new List<HouseAddress>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListHouseAddress = context.HouseAddresses.Where(x => x.House_Id == id).ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListHouseAddress;
        }
        public void AddHouseAddress(HouseAddress houseAddress)
        {
            try
            {
                var db = new AppDbContext();
                db.HouseAddresses.Add(houseAddress);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void UpdateHouseAddress(HouseAddress HouseAddress)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    context.Entry<HouseAddress>(HouseAddress).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteHouseAddressWithHouseId(int id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var rDelete = context.HouseAddresses.Where(x => x.House_Id == id);
                    foreach (var r in rDelete)
                    {
                        context.HouseAddresses.Remove(r);
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteHouseAddressWithLocationId(int id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var rDelete = context.HouseAddresses.SingleOrDefault(x => x.Location_Id == id);
                    context.HouseAddresses.Remove(rDelete);
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
