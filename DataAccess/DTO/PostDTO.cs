using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class PostDTO
    {
        public int PId { get; set; }
        public bool PostStatus { get; set; }
        public int? AdId { get; set; }
        public string PostContent { get; set; }
        public string PostCreatedDay { get; set; }
        public string PostTitle { get; set; }
        public int UId { get; set; }
    }
}
