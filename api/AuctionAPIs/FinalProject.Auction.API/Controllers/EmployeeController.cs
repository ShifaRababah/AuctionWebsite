using FinalProject.Auction.Core.Data;
using FinalProject.Auction.Core.DTO;
using FinalProject.Auction.Core.Service;
using FinalProject1.Auction1.Core.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Auction.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public readonly IEmployeeService _employeeService;


        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;


        }

        [HttpPost]
        [Route("AddNewEmployee")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public bool AddNewEmployee(AddNewEmployeeDTO newEmployee)
        {
            return _employeeService.AddNewEmployee(newEmployee);
        }

        [HttpGet]
        [Route("showEmp")]
        [ProducesResponseType(typeof(List<empDTO>), StatusCodes.Status200OK)]
        public List<empDTO> GetAllEmployee()
        {
            return _employeeService.GetAllEmployee();

        }


        [HttpPost]
        [Route("GetUserByEmail")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public Login GetUserByEmail(Login login)
        {
            return _employeeService.GetUserByEmail(login);

        }

        [HttpGet]
        [Route("CountEmp")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public CountEmpDTO CountEmp()
        {
            return _employeeService.CountEmp();

        }

        [HttpGet]
        [Route("GetProfits")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ProfitsDTO Profits()
        {
            return _employeeService.Profits();

        }

        [HttpGet]
        [Route("Countord")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public CountorderDTO Countord()
        {
            return _employeeService.Countord();

        }
        [HttpGet]
        [Route("GetAllOrder")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<GetAllOrderDTO> GetAllOrder()
        {
            return _employeeService.GetAllOrder();
        }

        [HttpPost]
        [Route("ProfitsByDate")]
        [ProducesResponseType(typeof(List<ProfitsByDateDTO>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public List<ProfitsByDateDTO> ProfitsByDate(ProfitsByDateDTO prof)
        {
            return _employeeService.ProfitsByDate(prof);
        }

        }
}
