using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FinalProject.Auction.Core.Data
{
    public class HomePage
    {
        [Key]
        public int HomeId { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string Logo { get; set; }

        public ICollection<System> system { get; set; }
    }
}
