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
        public int AdminId { get; set; }
        public int LessorId { get; set; }
        public int LesseId { get; set; }
        public virtual ICollection<History> Histories { get; set; }
    }
}
