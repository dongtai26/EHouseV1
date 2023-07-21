using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public class PaymentDestination
    {
        [Key]
        public string Id { get; set; }
        public string DesLogo { get; set; }
        public string DesShortName { get; set; }
        public string DesName { get; set; }
        public int DesSortIndex { get; set; }
        public string ParentId { get; set; }
        [ForeignKey("ParentId")]
        public virtual Payment Payment { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
