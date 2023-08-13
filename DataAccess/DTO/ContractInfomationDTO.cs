using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class ContractInfomationDTO
    {
        public int ConId { get; set; }
        public int HoId { get; set; }
        public float Area { get; set; }
        public int? LeId { get; set; }
        public string FullName1 { get; set; }
        public string CitizenIdentification1 { get; set; }
        public int? LesId { get; set; }
        public string FullName2 { get; set; }
        public string CitizenIdentification2 { get; set; }
    }
}
