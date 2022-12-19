using FinalProject.Auction.Core.Data;
using FinalProject.Auction.Core.Service;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Auction.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomePageController : ControllerBase
    {

        public readonly IHomePageService _homePageService;
        public static IWebHostEnvironment _webHostEnvironment;


        public HomePageController(IHomePageService homePageService, IWebHostEnvironment webHostEnvironment)
        {
            _homePageService = homePageService;
            _webHostEnvironment = webHostEnvironment;

        }



        [HttpPut]
        [Route("UpdateHomePage")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool UpdateHomePage([FromForm] HomePage homePage, IFormFile Image)
        {

            var pathImage = Path.Combine(_webHostEnvironment.WebRootPath, "images", Image.FileName);
            var streamImage = new FileStream(pathImage, FileMode.Append);
            Image.CopyTo(streamImage);
            var pr = new HomePage
            {
                HomeId = homePage.HomeId,

                Email = homePage.Email,
                PhoneNumber = homePage.PhoneNumber,
                
                
                Logo = pathImage,
               
            };

            _homePageService.UpdateHomePage(pr);
            return _homePageService.UpdateHomePage(homePage);
        }

    }
    }
