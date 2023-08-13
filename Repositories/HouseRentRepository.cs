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
        public List<HouseRentDTO> GetHouseRentsByRentPriceRange(float minRentPrice, float maxRentPrice)
        {
            return HouseRentDAO.GetHouseRentsByRentPriceRange(minRentPrice, maxRentPrice).Select(m => Mapper.mapToDTO(m)).ToList();
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
        public void UpdateAddress(HouseRentAddressDTO houseRentAddressDTO)
        {
            HouseRentDAO.UpdateHouseRent(Mapper.mapToEntityAddress(houseRentAddressDTO));
        }
        public HouseRentDTO GetHouseRentById(int id)
        {
            return Mapper.mapToDTO(HouseRentDAO.GetHouseRentById(id));
        }

        public List<HouseRentAddressDTO> GetAddress()
        {
            return HouseRentDAO.GetAddress().Select(m => Mapper.mapToDTOAddress(m)).ToList();
        }

        public HouseRentAddressDTO GetAddressHouseRentById(int id)
        {
            return Mapper.mapToDTOAddress(HouseRentDAO.GetAddressHouseRentById(id));
        }
        public List<HouseRentDTO> GetHouseRentsByLessorIdAndHouseStatus(int id, bool houseStatus)
        {
            return HouseRentDAO.GetHouseRentsByLessorIdAndHouseStatus(id, houseStatus).Select(m => Mapper.mapToDTO(m)).ToList();
        }
        public int CountTotalHouseRent()
        {
            return HouseRentDAO.CountTotalHouseRent();
        }
        public int CountTotalHouseRentByStatusAreTrue()
        {
            return HouseRentDAO.CountTotalHouseRentByStatusAreTrue();
        }
        public int CountTotalHouseRentByStatusAreFalse()
        {
            return HouseRentDAO.CountTotalHouseRentByStatusAreFalse();
        }


        public List<HouseRentDTO> FilterHouseRent(float minArea, float maxArea, float minRentPrice, float maxRentPrice, bool airConditioning, bool waterHeater, bool wifi, bool washingMachine, bool parking, bool refrigerator, bool kitchen, bool houseStatus)
        {
            throw new NotImplementedException();
        }

        public HouseRentIdDTO GetHoidByName(string houseRentName)
        {
            throw new NotImplementedException();
        }

        public void UpdateStatus(int id, HouseStatusDTO houseStatussDTO)
        {
            throw new NotImplementedException();
        }

        public void UpdateHouseAddress(int id, HouseRentAddressDTO houseRentAddressDTO)
        {
            throw new NotImplementedException();
        }
    }
}
