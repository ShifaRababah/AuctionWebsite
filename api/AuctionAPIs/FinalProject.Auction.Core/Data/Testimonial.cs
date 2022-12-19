using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace FinalProject.Auction.Core.Data
{
    public class Testimonial
    {
        [Key]
        public int TestimonialId { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string Massege { get; set; }

        public ICollection<System> system { get; set; }

    }
}
