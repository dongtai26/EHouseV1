using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public class HouseAddress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HouseAddressId { get; set; }
        public int House_Id { get; set; }
        [ForeignKey("House_Id")]
        public virtual HouseRent HouseRent { get; set; }
        public int Location_Id { get; set; }
        [ForeignKey("Location_Id")]
        public virtual Location Location { get; set; }
    }
}
