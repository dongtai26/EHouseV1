using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObjects.Models
{
    public class UserRole
    {
        public int UId { get; set; }
        [ForeignKey("UId")]
        public virtual User User { get; set; }
        public int RId { get; set; }
        [ForeignKey("RId")]
        public virtual Role Role { get; set; }
    }
}
