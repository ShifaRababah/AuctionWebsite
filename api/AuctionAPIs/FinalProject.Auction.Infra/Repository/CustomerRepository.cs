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
   public class CustomerRepository : ICustomerRepository
    {

        private readonly IDbContext _dbContext;

        public CustomerRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool RegisterCustomer(RegisterCustomerDTO registerCustomer)
        {
            var p = new DynamicParameters();
            p.Add("@Name", registerCustomer.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Email", registerCustomer.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@PhoneNumber", registerCustomer.PhoneNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Salary", registerCustomer.Salary = null, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@Position", registerCustomer.Position = null, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Password", registerCustomer.Password, dbType: DbType.String, direction: ParameterDirection.Input);
           
            p.Add("@RoleId", registerCustomer.RoleId = 4, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("RegisterCustomer", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<CustomerDTO> GetAllCustomer()
        {
            IEnumerable<CustomerDTO> result = _dbContext.Connection.Query<CustomerDTO>("GetAllCustomer", commandType: CommandType.StoredProcedure);

            return result.ToList();

        }

        public List<Login> GetUserByEmail(Login login)
        {
            var p = new DynamicParameters();
            p.Add("@Email", login.Email, dbType: DbType.String, direction: ParameterDirection.Input);

            IEnumerable<Login> result = _dbContext.Connection.Query<Login>("GetUserbyEmail",p, commandType: CommandType.StoredProcedure);

            return result.ToList();

        }

        public CountCustomerDTO CountCustomer()
        {
            var result = _dbContext.Connection.Query<CountCustomerDTO>("CountCustomer", commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }
    }
}
