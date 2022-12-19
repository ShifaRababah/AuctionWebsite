using Dapper;
using FinalProject.Auction.Core.Common;
using FinalProject.Auction.Core.Data;
using FinalProject.Auction.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FinalProject.Auction.Infra.Repository
{
    public class BankRepository : IBankRepository
    {
        private readonly IDbContext _dbContext;

        public BankRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Bank> GetAllBank()
        {
            IEnumerable<Bank> result = _dbContext.Connection.Query<Bank>("GetAllBank", commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public List<Bank> getallBankbyuserid(Bank bank)
        {
            var p = new DynamicParameters();
            p.Add("@userid", bank.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);

            IEnumerable<Bank> result = _dbContext.Connection.Query<Bank>("getallBankbyuserid", p, commandType: CommandType.StoredProcedure);

            return result.ToList();

        }
        public bool updateBalance(Bank bank)
        {
            var p = new DynamicParameters();

            p.Add("@userid", bank.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Balance", bank.Balance, dbType: DbType.Double, direction: ParameterDirection.Input);
          
            var result = _dbContext.Connection.ExecuteAsync("updateBalance", p, commandType: CommandType.StoredProcedure);


            return true;
        }


    }
}
