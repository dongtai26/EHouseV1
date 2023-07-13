using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IHouseRentRepository
    {
        List<HouseRentDTO> GetHouseRentsByName(string houseRentName);
        List<HouseRentDTO> GetHouseRents();
        List<HouseRentDTO>  GetHouseRentsByLessorId(int id);
        void AddHouseRent(HouseRentDTO houseRentDTO);
        void UpdateHouseRent(HouseRentDTO houseRentDTO);
        void DeleteHouseRent(int id);
    }
}
