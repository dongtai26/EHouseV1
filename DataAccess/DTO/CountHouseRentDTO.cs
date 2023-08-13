using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class CountHouseRentDTO
    {
        public int totalHouseRent { get; set; }
        public int totalHouseRentAreTrue { get; set; }
        public int totalHouseRentAreFalse { get; set; }
    }
}
