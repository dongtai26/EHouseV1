using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class UserDTO
    {
        public int UId { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string CitizenIdentification { get; set; }
        public int PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string Gmail { get; set; }
        public string Avatar { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int RId { get; set; }
        public string RoleName { get; set; }
    }
}
