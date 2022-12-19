using FinalProject.Auction.Core.Data;
using FinalProject.Auction.Core.Repository;
using FinalProject.Auction.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Auction.Infra.Service
{
   public class TestimonialService: ITestimonialService
    {
        private readonly ITestimonialRepository testimonialRepository;

        public TestimonialService(ITestimonialRepository _testimonialRepository)
        {

            testimonialRepository = _testimonialRepository;



        }


        public bool CreateTestimonial(Testimonial testimonial) 
        { return testimonialRepository.CreateTestimonial(testimonial); }

        public List<Testimonial> GetAllTestimonial()
        { return testimonialRepository.GetAllTestimonial(); }

        public bool DeleteTestimonial(int id) 
        { return testimonialRepository.DeleteTestimonial(id); }
        public bool UpdateTestimonial(Testimonial testimonial) 
        { return testimonialRepository.UpdateTestimonial(testimonial); }

    }
}
