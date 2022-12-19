using Dapper;
using FinalProject.Auction.Core.Common;
using FinalProject.Auction.Core.Data;
using FinalProject.Auction.Core.DTO;
using FinalProject.Auction.Core.Repository;
using FinalProject1.Auction1.Core.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FinalProject.Auction.Infra.Repository
{
   public class EmployeeRepository : IEmployeeRepository
    {
        
        private readonly IDbContext _dbContext;

        public EmployeeRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public bool AddNewEmployee(AddNewEmployeeDTO newEmployee)
        {
            var p = new DynamicParameters();
            p.Add("@Name", newEmployee.Name , dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Email",newEmployee.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@PhoneNumber", newEmployee.PhoneNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Salary", newEmployee.Salary, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@Position", newEmployee.Position, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Password", newEmployee.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            
            p.Add("@RoleId", newEmployee.RoleId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("AddNewEmployee", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<empDTO> GetAllEmployee()
        {
            IEnumerable<empDTO> result = _dbContext.Connection.Query<empDTO>("GetAllEmp", commandType: CommandType.StoredProcedure);

            return result.ToList();

        }

        // to get userId By email
        public Login GetUserByEmail(Login login)
        { 
            var p = new DynamicParameters();
            p.Add("@email", login.Email, dbType: DbType.String, direction: ParameterDirection.Input);
           

            var result = _dbContext.Connection.Query<Login>("GetUserByEmail", p, commandType: CommandType.StoredProcedure);

            return result.SingleOrDefault();
        }


        public CountEmpDTO CountEmp()
        {
            var result = _dbContext.Connection.Query<CountEmpDTO>("CountEmp", commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }


        public ProfitsDTO Profits()
        {
            var result = _dbContext.Connection.Query<ProfitsDTO>("Profits", commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }


        public CountorderDTO Countord()
        {
            var result = _dbContext.Connection.Query<CountorderDTO>("Countorder", commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }

        public List<GetAllOrderDTO> GetAllOrder()
        {
            IEnumerable<GetAllOrderDTO> result = _dbContext.Connection.Query<GetAllOrderDTO>("GetAllOrder", commandType: CommandType.StoredProcedure);

            return result.ToList();

        }

        public List <ProfitsByDateDTO> ProfitsByDate(ProfitsByDateDTO prof)
        {
            var p = new DynamicParameters();
            p.Add("@startDate", prof.StartDate, dbType: DbType.Date, direction: ParameterDirection.Input);
            p.Add("@endDate", prof.EndDate, dbType: DbType.Date, direction: ParameterDirection.Input);


            IEnumerable<ProfitsByDateDTO> result = _dbContext.Connection.Query<ProfitsByDateDTO>("SearchForProfitsByStartAndEndDate", p, commandType: CommandType.StoredProcedure);
            return result.ToList();

        }
    }
}
