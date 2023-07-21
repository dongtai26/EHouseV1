using BusinessObjects.Data;
using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class LocationDAO
    {
        public List<Location> GetLocations()
        {
            var ListLocation = new List<Location>();
            try
            {
                using (var context = new AppDbContext())
                {
                    ListLocation = context.Locations.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return ListLocation;
        }
        public Location GetLastLocation()
        {
            Location location = new Location();
            try
            {
                var db = new AppDbContext();
                location = db.Locations.OrderBy(m => m.LId).Last();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return location;
        }
        public Location GetLocationsByLocationId(int id)
        {
            Location location = new Location();
            try
            {
                using (var context = new AppDbContext())
                {
                    location = context.Locations.SingleOrDefault(x => x.LId == id);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return location;
        }
        public void AddLocation(Location location)
        {
            try
            {
                var db = new AppDbContext();
                db.Locations.Add(location);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void UpdateLocation(Location location)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    context.Entry<Location>(location).State =  Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteLocation(int id)
        {
            try
            {
                using (var context = new AppDbContext())
                {
                    var rDelete = context.Locations.SingleOrDefault(x => x.LId == id);
                    context.Locations.Remove(rDelete);
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
