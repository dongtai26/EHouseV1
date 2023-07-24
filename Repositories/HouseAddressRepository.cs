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
    public class HouseAddressRepository : IHouseAddressRepository
    {
        HouseAddressDAO houseAddressDAO = new HouseAddressDAO();
        public void AddHouseAddress(HouseAddressDTO houseAddressDTO)
        {
            houseAddressDAO.AddHouseAddress(Mapper.mapToEntity(houseAddressDTO));
        }
        public void DeleteHouseAddressWithHouseId(int id)
        {
            houseAddressDAO.DeleteHouseAddressWithHouseId(id);
        }
        public void DeleteHouseAddressWithLocationId(int id)
        {
            houseAddressDAO.DeleteHouseAddressWithLocationId(id);
        }
        public List<HouseAddressDTO> GetHouseAddresses()
        {
            return houseAddressDAO.GetHouseAddresses().Select(m => Mapper.mapToDTO(m)).ToList();
        }
        public List<HouseAddressDTO> GetHouseAddressesByHouseRentId(int id)
        {
            return houseAddressDAO.GetHouseAddressesByHouseRentId(id).Select(m => Mapper.mapToDTO(m)).ToList();
        }
        public void UpdateHouseAddress(HouseAddressDTO houseAddressDTO)
        {
            houseAddressDAO.UpdateHouseAddress(Mapper.mapToEntity(houseAddressDTO));
        }
    }
}
