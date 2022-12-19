using FinalProject.Auction.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Auction.Core.Services
{
    public interface IBankService
    {
        List<Bank> GetAllBank();

        List<Bank> getallBankbyuserid(Bank bank);
        bool updateBalance(Bank bank);
    }
}
