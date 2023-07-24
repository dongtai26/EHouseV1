using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class NotificationDTO
    {
        public int NoId { get; set; }
        public string NoContent { get; set; }
        public string NoName { get; set; }
        public int PId { get; set; }
        public int UId { get; set; }
        public int CId { get; set; }
    }
}
