using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public class HouseImage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int HIId { get; set; }
        public string HouseImageCode { get; set; }
        public int HoId { get; set; }
        [ForeignKey("HoId")]
        public virtual HouseRent HouseRent { get; set; }
    }
}
