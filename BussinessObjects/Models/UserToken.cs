using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObjects.Models
{
    public class UserToken
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TId { get; set; }
        public string? Jwt { get; set; }
        public int UId { get; set; }
        [ForeignKey("UId")]
        public virtual User User { get; set; }
    }
}
