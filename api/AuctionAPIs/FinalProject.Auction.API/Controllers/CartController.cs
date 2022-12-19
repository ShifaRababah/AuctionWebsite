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
    public class CartController : ControllerBase
    {
        public readonly ICartService _cartService;


        public CartController(ICartService cartService)
        {
            _cartService = cartService;


        }

        [HttpPost]
        [Route("GetAllCart/{id}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public Cart GetAllCart(int id)
        {
            return _cartService.GetAllCart(id);
        }


            [HttpPost]
        [Route("CreateCart")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateCart(Cart cart)
        {
            return _cartService.CreateCart(cart);
        }



        [HttpDelete]
        [Route("DeleteCart/{id}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool DeleteCart(int id)
        {
            return _cartService.DeleteCart(id);
        }



    }

}
