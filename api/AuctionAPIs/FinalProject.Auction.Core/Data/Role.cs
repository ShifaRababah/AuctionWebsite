using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FinalProject.Auction.Core.Data
{
    public class Role
    {
        [Key]
        public int RoleId { get;set; }

        public string RoleName { get; set; }

        public int LoginType { get; set; }

        public ICollection<Login> login { get; set; }

    }
}
