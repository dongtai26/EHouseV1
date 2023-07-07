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
        public int AdminId { get; set; }
        public int LessorId { get; set; }
        public int LesseId { get; set; }
    }
}
