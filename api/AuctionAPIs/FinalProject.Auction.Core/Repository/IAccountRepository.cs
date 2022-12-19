using FinalProject.Auction.Core.Data;
using FinalProject1.Auction1.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject1.Auction1.Core.Repository
{
    public interface IAccountRepository
    {
        bool CreateAccount(Account account);
        List<AccountDTO> GetAllAccount();
    }
}
