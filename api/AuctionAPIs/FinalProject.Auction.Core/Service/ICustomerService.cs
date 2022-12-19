using FinalProject.Auction.Core.Data;
using FinalProject.Auction.Core.DTO;
using FinalProject1.Auction1.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Auction.Core.Service
{
  public interface ICustomerService
    {
        bool RegisterCustomer(RegisterCustomerDTO registerCustomer);
        List<CustomerDTO> GetAllCustomer();
        List<Login> GetUserByEmail(Login login);

         CountCustomerDTO CountCustomer();

    }
}
