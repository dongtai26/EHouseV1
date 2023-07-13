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
    public class HouseRentRepository : IHouseRentRepository
    {
        HouseRentDAO HouseRentDAO = new HouseRentDAO();
        public void AddHouseRent(HouseRentDTO houseRentDTO)
        {
            HouseRentDAO.AddHouseRent(Mapper.mapToEntity(houseRentDTO));
        }
        public void DeleteHouseRent(int id)
        {
            HouseRentDAO.DeleteHouseRent(id);
        }
        public List<HouseRentDTO> GetHouseRentsByName(string houseRentName)
        {
            return HouseRentDAO.GetHouseRentsByName(houseRentName).Select(m => Mapper.mapToDTO(m)).ToList();
        }
        public List<HouseRentDTO> GetHouseRents()
        {
            return HouseRentDAO.GetHouseRents().Select(m => Mapper.mapToDTO(m)).ToList();
        }
        public List<HouseRentDTO> GetHouseRentsByLessorId(int id)
        {
            return HouseRentDAO.GetHouseRentsByLessorId(id).Select(m => Mapper.mapToDTO(m)).ToList();
        }
        public void UpdateHouseRent(HouseRentDTO houseRentDTO)
        {
            HouseRentDAO.UpdateHouseRent(Mapper.mapToEntity(houseRentDTO));
        }
        public HouseRentDTO GetHouseRentById(int id)
        {
            return Mapper.mapToDTO(HouseRentDAO.GetHouseRentById(id));
        }
    }
}
