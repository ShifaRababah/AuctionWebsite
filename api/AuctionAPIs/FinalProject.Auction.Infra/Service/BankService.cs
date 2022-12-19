using FinalProject.Auction.Core.Data;
using FinalProject.Auction.Core.Repository;
using FinalProject.Auction.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Auction.Infra.Services
{
    public class BankService : IBankService
    {
        private readonly IBankRepository bankRepository;

        public BankService(IBankRepository _bankRepository)
        {
            bankRepository = _bankRepository;
        }

        public List<Bank> GetAllBank()
        {
            return bankRepository.GetAllBank();
        }

        public List<Bank> getallBankbyuserid(Bank bank)
        {
            return bankRepository.getallBankbyuserid(bank);

        }
        public bool updateBalance(Bank bank)
        {
            return bankRepository.updateBalance(bank);
        }
    }
}
