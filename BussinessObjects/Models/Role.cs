using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObjects.Models
{
    public class Role
    {
        public int RId { get; set; }
        [ForeignKey("RId")]
        public virtual User User { get; set; }
        public string RoleName { get; set; }
    }
}
