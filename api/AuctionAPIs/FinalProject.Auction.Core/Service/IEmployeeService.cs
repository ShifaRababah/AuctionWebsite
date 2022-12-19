using FinalProject.Auction.Core.Data;
using FinalProject.Auction.Core.DTO;
using FinalProject1.Auction1.Core.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.Auction.Core.Service
{
  public interface IEmployeeService
    {
        bool AddNewEmployee(AddNewEmployeeDTO newEmployee);
        List<empDTO> GetAllEmployee();
        Login GetUserByEmail(Login login);
        CountEmpDTO CountEmp();
        ProfitsDTO Profits();
       CountorderDTO Countord();
        List<GetAllOrderDTO> GetAllOrder();
      List<ProfitsByDateDTO> ProfitsByDate(ProfitsByDateDTO prof);
        



        }
}
