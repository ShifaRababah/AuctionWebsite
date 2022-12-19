using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Auction.Core.Data;
using FinalProject.Auction.Core.Service;
using FinalProject1.Auction1.Core.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject1.Auction1.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuctionController : Controller
    {
        private readonly IAuctionService auctionService;


        public AuctionController(IAuctionService _auctionService)
        {

            auctionService = _auctionService;
        }


        [HttpPut]
        [Route("UpdateAuction")]

        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public bool UpdateAuctionPrice1(Auctionn auctionn)
        {
            return auctionService.UpdateAuctionPrice(auctionn);

        }

        [HttpGet]
        [Route("showAuction")]
        [ProducesResponseType(typeof(List<AuctionnDTO>), StatusCodes.Status200OK)]
        public List<AuctionnDTO> GetAllCAuction()
        {

            return auctionService.GetAllAuctionn();

        }

    }
}