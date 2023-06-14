using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessObjects.Models
{
    public class Image
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IId { get; set; }
        public string ImageCode { get; set; }
        public string ImageName { get; set; }
        public string ImageContent { get; set; }
        public int PId { get; set; }
        [ForeignKey("PId")]
        public virtual Post Post { get; set; }
    }
}
