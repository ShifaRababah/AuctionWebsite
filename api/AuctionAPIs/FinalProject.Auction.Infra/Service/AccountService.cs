using FinalProject.Auction.Core.Data;
using FinalProject.Auction.Core.Repository;
using FinalProject1.Auction1.Core.DTO;
using FinalProject1.Auction1.Core.Repository;
using FinalProject1.Auction1.Core.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject1.Auction1.Infra.Service
{
   public class AccountService: IAccountService
    {

        private readonly IAccountRepository accountRepository;
        public AccountService(IAccountRepository _accountRepository)
        {
            accountRepository = _accountRepository;
        }


        public bool CreateAccount(Account account)
        {
            return accountRepository.CreateAccount(account);
        }

        public List<AccountDTO> GetAllAccount()
        {
            return accountRepository.GetAllAccount();

        }
    }
}