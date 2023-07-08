using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class HouseRentDTO
    {
        public int HoId { get; set; }
        public string HouseRentName { get; set; }
        public float Area { get; set; }
        public bool AirConditioning { get; set; }
        public bool WaterHeater { get; set; }
        public bool Wifi { get; set; }
        public bool WashingMachine { get; set; }
        public bool Bed { get; set; }
        public bool Parking { get; set; }
        public bool Refrigerator { get; set; }
        public bool Restroom { get; set; }
        public float ElectricityPrice { get; set; }
        public float WaterPrice { get; set; }
        public float RentPrice { get; set; }
        public string HouseStatus { get; set; }
        public int LeId { get; set; }
    }
}
