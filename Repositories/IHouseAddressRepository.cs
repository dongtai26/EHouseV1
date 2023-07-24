using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IHouseAddressRepository
    {
        List<HouseAddressDTO> GetHouseAddresses();
        List<HouseAddressDTO> GetHouseAddressesByHouseRentId(int id);
        void AddHouseAddress(HouseAddressDTO houseAddressDTO);
        void UpdateHouseAddress(HouseAddressDTO houseAddressDTO);
        void DeleteHouseAddressWithHouseId(int id);
        void DeleteHouseAddressWithLocationId(int id);
    }
}
