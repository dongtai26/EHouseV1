using DataAccess.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface IHouseImageRepository
    {
        List<HouseImageDTO> GetHouseImages();
        void AddHouseImage(HouseImageDTO houseImageDTO);
        void UpdateHouseImage(HouseImageDTO houseImageDTO);
        void DeleteHouseImage(int id);
    }
}
