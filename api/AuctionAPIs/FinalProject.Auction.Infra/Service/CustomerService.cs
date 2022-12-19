using FinalProject.Auction.Core.Data;
using FinalProject.Auction.Core.DTO;
using FinalProject.Auction.Core.Repository;
using FinalProject.Auction.Core.Service;
using FinalProject1.Auction1.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Auction.Infra.Service
{
  public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }


        public bool RegisterCustomer(RegisterCustomerDTO registerCustomer)
        {
            return _customerRepository.RegisterCustomer(registerCustomer);
        }
        public List<CustomerDTO> GetAllCustomer()
        {
            return _customerRepository.GetAllCustomer();

        }
        public List<Login> GetUserByEmail(Login login)
        {
            return _customerRepository.GetUserByEmail(login);

        }


        public CountCustomerDTO CountCustomer()
        {
            return _customerRepository.CountCustomer();
        }

    }
}
