using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UId { get; set; }
        public string FullName { get; set; }
        public DateTime Dateofbirth { get; set; }
        public string Address { get; set; }
        public string CitizenIdentification { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public string Gmail { get; set; }
        public string Avatar { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int RId { get; set; }
        [ForeignKey("RId")]
        public virtual Role Role { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
