using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public class Admin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdId { get; set; }
        public int UId { get; set; }
        [ForeignKey("UId")]
        public virtual User User { get; set; }
        public virtual ICollection<Contract> Contracts { get; set; }
    }
}
