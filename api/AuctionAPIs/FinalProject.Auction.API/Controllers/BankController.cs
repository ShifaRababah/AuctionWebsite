using FinalProject.Auction.Core.Data;
using FinalProject.Auction.Core.Services;
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
    public class BankController : ControllerBase
    {
        private readonly IBankService bankService;

        public BankController(IBankService _bankService)
        {
            bankService = _bankService;
        }

        [HttpGet]
        [Route("GetAllBank")]
        [ProducesResponseType(typeof(List<>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Bank> GetAllBank()
        {
            return bankService.GetAllBank();
        }

        [HttpPost]
        [Route("getallBankbyuserid")]
        [ProducesResponseType(typeof(List<Bank>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<Bank> getallBankbyuserid(Bank bank)
        {
            return bankService.getallBankbyuserid(bank);

        }

        [HttpPut]
        [Route("updateBalance")]

        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public bool updateBalance(Bank bank)
        {
            return bankService.updateBalance(bank);

        }
    }
}
