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
        public List<HouseRentDTO> GetHouseRentsByDetail(string detail)
        {
            return HouseRentDAO.GetHouseRentsByDetail(detail).Select(m => Mapper.mapToDTO(m)).ToList();
        }
        public List<HouseRentDTO> GetHouseRentsByAreaRange(float minArea, float maxArea)
        {
            return HouseRentDAO.GetHouseRentsByAreaRange(minArea, maxArea).Select(m => Mapper.mapToDTO(m)).ToList();
        }
        public List<HouseRentDTO> GetHouseRentsByRentPriceRange(float minRentPrice, float maxPrice)
        {
            return HouseRentDAO.GetHouseRentsByRentPriceRange(minRentPrice, maxPrice).Select(m => Mapper.mapToDTO(m)).ToList();
        }
        public List<HouseRentDTO> GetHouseRentsByAirConditioning(bool airConditioning)
        {
            return HouseRentDAO.GetHouseRentsByAirConditioning(airConditioning).Select(m => Mapper.mapToDTO(m)).ToList();
        }
        public List<HouseRentDTO> GetHouseRentsByWaterHeater(bool waterHeater)
        {
            return HouseRentDAO.GetHouseRentsByWaterHeater(waterHeater).Select(m => Mapper.mapToDTO(m)).ToList();
        }
        public List<HouseRentDTO> GetHouseRentsByWifi(bool wifi)
        {
            return HouseRentDAO.GetHouseRentsByWifi(wifi).Select(m => Mapper.mapToDTO(m)).ToList();
        }
        public List<HouseRentDTO> GetHouseRentsByWashingMachine(bool washingMachine)
        {
            return HouseRentDAO.GetHouseRentsByWashingMachine(washingMachine).Select(m => Mapper.mapToDTO(m)).ToList();
        }
        public List<HouseRentDTO> GetHouseRentsByParking(bool parking)
        {
            return HouseRentDAO.GetHouseRentsByParking(parking).Select(m => Mapper.mapToDTO(m)).ToList();
        }
        public List<HouseRentDTO> GetHouseRentsByRefrigerator(bool refrigerator)
        {
            return HouseRentDAO.GetHouseRentsByRefrigerator(refrigerator).Select(m => Mapper.mapToDTO(m)).ToList();
        }
        public List<HouseRentDTO> GetHouseRentsByKitchen(bool kitchen)
        {
            return HouseRentDAO.GetHouseRentsByKitchen(kitchen).Select(m => Mapper.mapToDTO(m)).ToList();
        }
        public List<HouseRentDTO> GetHouseRentsByHouseStatus(bool houseStatus)
        {
            return HouseRentDAO.GetHouseRentsByHouseStatus(houseStatus).Select(m => Mapper.mapToDTO(m)).ToList();
        }
        public List<HouseRentDTO> GetHouseRentsByBed(int bed)
        {
            return HouseRentDAO.GetHouseRentsByBed(bed).Select(m => Mapper.mapToDTO(m)).ToList();
        }
        public List<HouseRentDTO> GetHouseRentsByRestroom(int restroom)
        {
            return HouseRentDAO.GetHouseRentsByRestroom(restroom).Select(m => Mapper.mapToDTO(m)).ToList();
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
