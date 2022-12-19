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
    public class JWTController : ControllerBase
    {



        private readonly IJWTService iJWTService;




        public JWTController(IJWTService _iJWTService)
        {



            iJWTService = _iJWTService;
        }



        [HttpPost]
        [ProducesResponseType(typeof(IActionResult), StatusCodes.Status200OK)]



        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Route("JWT1")]
        public IActionResult Auth(Login login)
        {
            var result = iJWTService.Auth(login);
            if (result == null)
            {
                return Unauthorized();
            }
            else
            {
                return Ok(result);
            }
        }
    }
}
