﻿using DataAccess.DTO;
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
        List<HouseRentDTO> GetHouseRentsByDetail(string detail);
        List<HouseRentDTO> GetHouseRents();
        List<HouseRentDTO> GetHouseRentsByLessorId(int id);
        List<HouseRentDTO> GetHouseRentsByAreaRange(float minArea, float maxArea);
        List<HouseRentDTO> GetHouseRentsByRentPriceRange(float minRentPrice, float maxRentPrice);
        List<HouseRentDTO> GetHouseRentsByAirConditioning(bool airConditioning);
        List<HouseRentDTO> GetHouseRentsByWaterHeater(bool waterHeater);
        List<HouseRentDTO> GetHouseRentsByWifi(bool wifi);
        List<HouseRentDTO> GetHouseRentsByWashingMachine(bool washingMachine);
        List<HouseRentDTO> GetHouseRentsByParking(bool parking);
        List<HouseRentDTO> GetHouseRentsByRefrigerator(bool refrigerator);
        List<HouseRentDTO> GetHouseRentsByKitchen(bool kitchen);
        List<HouseRentDTO> GetHouseRentsByHouseStatus(bool houseStatus);
        List<HouseRentDTO> GetHouseRentsByBed(int bed);
        List<HouseRentDTO> GetHouseRentsByRestroom(int restroom);
        HouseRentDTO GetHouseRentById(int id);
        void AddHouseRent(HouseRentDTO houseRentDTO);
        void UpdateHouseRent(HouseRentDTO houseRentDTO);
        void DeleteHouseRent(int id);
    }
}