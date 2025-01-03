﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects.Models
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CId { get; set; }
        public string CommentContent { get; set; }
        public string LastTimeModified { get; set; }
        public int PId { get; set; }
        [ForeignKey("PId")]
        public virtual Post Post { get; set; }
        public int UId { get; set; }
        [ForeignKey("UId")]
        public virtual User User { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
