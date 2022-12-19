using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FinalProject.Auction.Core.Data
{
    public class System
    {
        [Key]
        public int SystemId { get; set; }

        public int HomepageId { get; set; }
        [ForeignKey("HomepageId")]
        public virtual HomePage homePage { get; set; }

        public int TestimonialId { get; set; }
        [ForeignKey("TestimonialId")]
        public virtual Testimonial testimonial { get; set; }
    }
}
