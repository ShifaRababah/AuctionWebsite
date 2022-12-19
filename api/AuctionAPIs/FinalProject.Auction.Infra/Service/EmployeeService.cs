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
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }


        public bool AddNewEmployee(AddNewEmployeeDTO newEmployee)
        {
            return _employeeRepository.AddNewEmployee(newEmployee);
        }

        public List<empDTO> GetAllEmployee()
        {
            return _employeeRepository.GetAllEmployee();

        }

        public Login GetUserByEmail(Login login)
        {
            return _employeeRepository.GetUserByEmail(login);
        }

        public CountEmpDTO CountEmp()
        {
            return _employeeRepository.CountEmp();
        }
        public ProfitsDTO Profits()
        {
            return _employeeRepository.Profits();
        }

        public CountorderDTO Countord()
        {
            return _employeeRepository.Countord();
        }



        public List<GetAllOrderDTO> GetAllOrder()
        {
            return _employeeRepository.GetAllOrder();

        }
        public List<ProfitsByDateDTO> ProfitsByDate(ProfitsByDateDTO prof)
        {
            return _employeeRepository.ProfitsByDate(prof);
        }
        }
}
