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
    public class AttendController : ControllerBase
    {
        private readonly IAttendService attendService;
        public AttendController(IAttendService _attendService)
        {

            attendService = _attendService;




        }
        [HttpPost]
        [Route("CreateAttend")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateCategory(Attend attend)
        {


            return attendService.CreateAttend(attend);

        }
    }
}
