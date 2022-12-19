using FinalProject.Auction.Core.Data;
using FinalProject.Auction.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Auction.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService testimonialService;
        public TestimonialController(ITestimonialService _testimonialService)
        {

            testimonialService = _testimonialService;



        }
        [HttpGet]//Type of http method
        [ProducesResponseType(typeof(List<Testimonial>), StatusCodes.Status200OK)]
        public List<Testimonial> GetAllTestimonial()
        {
            return testimonialService.GetAllTestimonial();
        }

        [HttpPut]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateTestimonial(Testimonial testimonial)
        {

            return testimonialService.UpdateTestimonial(testimonial);

        }
        [HttpDelete]
        [Route("DeleteTestimonial{id}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteTestimonial(int id)
        {

            return testimonialService.DeleteTestimonial(id);
        }
        [HttpPost]
        [Route("CreateTestimonial")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateTestimonial(Testimonial testimonial)
        {


            return testimonialService.CreateTestimonial(testimonial);

        }



    }

}
