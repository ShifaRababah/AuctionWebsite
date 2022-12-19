using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FinalProject.Auction.Core.Data
{
    public class Login
    {
        [Key]
        public int LoginId { get; set; }

        public string Email { get; set;}
         
        public string Password { get; set; }

        public int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual Useres users { get; set; }

        public int RoleId { get; set; }
        [ForeignKey("RoleId")]
        public virtual Role role { get; set; }
    }
}
