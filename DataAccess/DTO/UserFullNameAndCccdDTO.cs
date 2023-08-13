using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class UserFullNameAndCccdDTO
    {
        public int UId { get; set; }
        public string FullName { get; set; }
        public string CitizenIdentification { get; set; }
    }
}
