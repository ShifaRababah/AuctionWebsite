using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FinalProject.Auction.Core.Data
{
    public class Useres
    {
        [Key]
        public int UserId { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public float? Salary { get; set; }

        public string Position { get; set; }

        public ICollection<Account> account { get; set; }

        public ICollection<Attend> attend { get; set; }

        public ICollection<Auctionn> auction { get; set; }

        public ICollection<Product> product { get; set; }

        public ICollection<Bank> bank { get; set; }

        public ICollection<Cart> cart { get; set; }

        public ICollection<Login> login { get; set; }

        public ICollection<Order> order { get; set; }
    }
}
