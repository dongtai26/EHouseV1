using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class CommentDTO
    {
        public int CId { get; set; }
        public string CommentContent { get; set; }
        public string LastTimeModified { get; set; }
        public int PId { get; set; }
        public int UId { get; set; }
    }
}
