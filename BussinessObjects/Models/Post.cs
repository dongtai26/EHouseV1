using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PId { get; set; }
        public string PostStatus { get; set; }
        public string PostContent { get; set; }
        public DateTime PostCreatedDay { get; set; }
        public string PostTitle { get; set; }
        public int UId { get; set; }
        [ForeignKey("UId")]
        public virtual User User { get; set; }
        public virtual ICollection<Comment> Comment { get; set; }
        public virtual ICollection<History> Histories { get; set; }
        public virtual ICollection<PostImage> PostImages { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }

    }
}
