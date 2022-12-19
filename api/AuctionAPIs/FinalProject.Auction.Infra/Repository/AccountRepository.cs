using Dapper;
using FinalProject.Auction.Core.Common;
using FinalProject.Auction.Core.Data;
using FinalProject1.Auction1.Core.DTO;
using FinalProject1.Auction1.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FinalProject1.Auction1.Infra.Repository
{
   public  class AccountRepository: IAccountRepository
    {
        private readonly IDbContext _dbContext;



        public AccountRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public bool CreateAccount(Account account)
        {
            var p = new DynamicParameters();
            p.Add("@Value", account.Value, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@Description", account.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Date", account.Date, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@UserId", account.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("CreateAccount", p, commandType: CommandType.StoredProcedure);


            return true;
        }

        public List<AccountDTO> GetAllAccount()
        {
            IEnumerable<AccountDTO> result = _dbContext.Connection.Query<AccountDTO>("showAccountInfo", commandType: CommandType.StoredProcedure);

            return result.ToList();

        }

    }
}
