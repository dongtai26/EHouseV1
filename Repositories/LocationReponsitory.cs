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
    public class LocationReponsitory : ILocationRepository
    {
        LocationDAO locationDAO = new LocationDAO();
        public void AddLocation(LocationDTO locationDTO)
        {
            locationDAO.AddLocation(Mapper.mapToEntity(locationDTO));
        }
        public LocationDTO GetLastLocation()
        {
            return Mapper.mapToDTO(locationDAO.GetLastLocation());
        }
        public void DeleteLocation(int id)
        {
            locationDAO.DeleteLocation(id);
        }
        public List<LocationDTO> GetLocations()
        {
            return locationDAO.GetLocations().Select(m => Mapper.mapToDTO(m)).ToList();
        }
        public LocationDTO GetLocationByLocationId(int id)
        {
            return Mapper.mapToDTO(locationDAO.GetLocationsByLocationId(id));
        }
        public void UpdateLocation(LocationDTO locationDTO)
        {
            locationDAO.UpdateLocation(Mapper.mapToEntity(locationDTO));
        }
    }
}
