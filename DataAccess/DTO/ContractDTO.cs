using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class ContractDTO
    {
        public int ConId { get; set; }
        public DateTime ContractCreatedDay { get; set; }
        public string ContractContent { get; set; }
        public DateTime ContractApproveDay { get; set; }
        public int HoId { get; set; }
        public int? AdId { get; set; }
        public bool StatusAdminId { get; set; }
        public int? LeId { get; set; }
        public bool StatusLessorId { get; set; }
        public int? LesId { get; set; }
    }
}
