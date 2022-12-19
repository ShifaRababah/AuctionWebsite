using FinalProject.Auction.Core.Data;
using FinalProject.Auction.Core.DTO;
using FinalProject.Auction.Core.Service;
using FinalProject1.Auction1.Core.DTO;
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
    public class CustomerController : ControllerBase
    {
        public readonly ICustomerService _customerService;


        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;


        }

        [HttpPost]
        [Route("RegisterCustomer")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool RegisterCustomer(RegisterCustomerDTO registerCustomer)
        {
            return _customerService.RegisterCustomer(registerCustomer);

            
        }

        [HttpGet]
        [Route("showCustomer")]
        [ProducesResponseType(typeof(List<CustomerDTO>), StatusCodes.Status200OK)]
        public List<CustomerDTO> GetAllCustomer()
        {
            return _customerService.GetAllCustomer();

        }

        [HttpPost]
        [Route("GetUserByEmail1")]
        [ProducesResponseType(typeof(List<Login>), StatusCodes.Status200OK)]
        public List<Login> GetUserByEmail( Login login)
        {

            return _customerService.GetUserByEmail(login);

        }

        [HttpGet]
        [Route("CountCustomer")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public CountCustomerDTO CountCustomer()
        {
            return _customerService.CountCustomer();

        }

    }
}
