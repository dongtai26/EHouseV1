using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public class PaymentSignature
    {
        [Key]
        public string Id { get; set; }
        public string SignValue { get; set; }
        public string SignAlgo { get; set; }
        public DateTime SignDate { get; set; }
        public string SignOwn { get; set; }
        public string PaymentId { get; set; }
        [ForeignKey("ParentId")]
        public virtual Payment Payment { get; set; }

    }
}
