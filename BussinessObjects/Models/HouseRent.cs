using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public class HouseRent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HoId { get; set; }
        public string HouseRentName { get; set; }
        public float Area { get; set; }
        public bool AirConditioning { get; set; }
        public bool WaterHeater { get; set; }
        public bool Wifi { get; set; }
        public bool WashingMachine { get; set; }
        public int Bed { get; set; }
        public bool Parking { get; set; }
        public bool Refrigerator { get; set; }
        public int Restroom { get; set; }
        public bool Kitchen { get; set; }
        public float ElectricityPrice { get; set; }
        public float WaterPrice { get; set; }
        public float RentPrice { get; set; }
        public bool HouseStatus { get; set; }
        public string Detail { get; set; }
        public int LeId { get; set; }
        [ForeignKey("LeId")]
        public virtual Lessor Lessor { get; set; }
    }
}
