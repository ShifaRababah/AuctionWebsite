using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Auction.Core.Data;
using FinalProject1.Auction1.Core.DTO;
using FinalProject1.Auction1.Core.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject1.Auction1.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {

        private readonly IAccountService accountService;


        public AccountController(IAccountService _accountService)
        {

            accountService = _accountService;
        }
        [HttpPost]
        [Route("CreateAccount")]
        // not now in final we do it . 
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool CreateAccount(Account account)
        {
            return accountService.CreateAccount(account);
        }
        [HttpGet]
        [Route("showAccount")]
        [ProducesResponseType(typeof(List<AccountDTO>), StatusCodes.Status200OK)]
        public List<AccountDTO> GetAllAccount()
        {
            return accountService.GetAllAccount();

        }



    }
}