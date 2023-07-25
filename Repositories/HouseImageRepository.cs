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
    public class HouseImageRepository : IHouseImageRepository
    {
        HouseImageDAO houseImageDAO = new HouseImageDAO();
        public void AddHouseImage(HouseImageDTO houseImageDTO)
        {
            houseImageDAO.AddHouseImage(Mapper.mapToEntity(houseImageDTO));
        }

        public void DeleteHouseImage(int id)
        {
            houseImageDAO.DeleteHouseImage(id);
        }

        public List<HouseImageDTO> GetHouseImageByHoId(int id)
        {
            return houseImageDAO.GetHouseImageByHoId(id).Select(m => Mapper.mapToDTO(m)).ToList();
        }

        public List<HouseImageDTO> GetHouseImages()
        {
            return houseImageDAO.GetHouseImages().Select(m => Mapper.mapToDTO(m)).ToList();
        }

        public void UpdateHouseImage(HouseImageDTO houseImageDTO)
        {
            houseImageDAO.UpdateHouseImage(Mapper.mapToEntity(houseImageDTO));
        }
    }
}
