using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public class Contract
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ConId { get; set; }
        public DateTime ContractCreatedDay { get; set; }
        public string ContractContent { get; set; }
        public DateTime ContractApproveDay { get; set; }
        public int HoId { get; set; }
        [ForeignKey("HoId")]
        public virtual HouseRent HouseRent { get; set; }
        public string HouseRentName { get; set; }
        public float RentPrice { get; set; }
        public int? AdId { get; set; }
        [ForeignKey("AdId")]
        public virtual Admin Admin { get; set; }
        public bool StatusAdminId { get; set; }
        public int? LeId { get; set; }
        [ForeignKey("LeId")]
        public virtual Lessor Lessor { get; set; }
        public bool StatusLessorId { get; set; }
        public int? LesId { get; set; }
        [ForeignKey("LesId")]
        public virtual Lessee Lessee { get; set; }
    }
}
