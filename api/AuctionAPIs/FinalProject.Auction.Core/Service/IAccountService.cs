using FinalProject.Auction.Core.Data;
using FinalProject1.Auction1.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject1.Auction1.Core.Service
{
    public interface IAccountService
    {
        bool CreateAccount(Account account);
        List<AccountDTO> GetAllAccount();

    }
}
