using FinalProject.Auction.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Auction.Core.Service
{
    public interface ITestimonialService
    {
        bool CreateTestimonial(Testimonial testimonial);
        List<Testimonial> GetAllTestimonial();
        public bool DeleteTestimonial(int id);
        public bool UpdateTestimonial(Testimonial testimonial);


    }
}
