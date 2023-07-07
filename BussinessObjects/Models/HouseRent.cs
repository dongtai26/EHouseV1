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
        public int Hoid { get; set; }
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
        public int PId { get; set; }
        [ForeignKey("PId")]
        public virtual Post Post { get; set; }
        public int LId { get; set; }
        [ForeignKey("LId")]
        public virtual Location Location { get; set; }
        public int LeId { get; set; }
        [ForeignKey("LeId")]
        public virtual Lessor Lessor { get; set; }


    }
}
