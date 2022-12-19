using FinalProject.Auction.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Auction.Core.Repository
{
    public interface ITestimonialRepository
    {
        bool CreateTestimonial(Testimonial testimonial);
        List<Testimonial> GetAllTestimonial();
        bool DeleteTestimonial(int id);
        bool UpdateTestimonial(Testimonial testimonial);




    }
}
