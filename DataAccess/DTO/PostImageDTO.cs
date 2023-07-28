using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class PostImageDTO
    {
        public int PIId { get; set; }
        public string PostImageUrl { get; set; }
        public string? PostImageName { get; set; }
        public string? PostImageContent { get; set; }
        public int PId { get; set; }
    }
}
