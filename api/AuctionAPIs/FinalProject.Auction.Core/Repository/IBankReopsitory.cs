using FinalProject.Auction.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Auction.Core.Repository
{
    public interface IBankRepository
    {
        List<Bank> GetAllBank();
        List<Bank> getallBankbyuserid(Bank bank);
        bool updateBalance(Bank bank);
    }
}
