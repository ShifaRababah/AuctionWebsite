using Dapper;
using FinalProject.Auction.Core.Common;
using FinalProject.Auction.Core.Data;
using FinalProject.Auction.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace FinalProject.Auction.Infra.Repository
{
   public class HomePageRepository: IHomePageRepository
    {

        private readonly IDbContext _dbContext;



        public HomePageRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool UpdateHomePage(HomePage homePage)
        {
            var p = new DynamicParameters();
            p.Add("@HomeId", homePage.HomeId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Email", homePage.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@PhoneNumber", homePage.PhoneNumber, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Logo", homePage.Logo, dbType: DbType.String, direction: ParameterDirection.Input);

            var result = _dbContext.Connection.ExecuteAsync("UpdateHomePage", p, commandType: CommandType.StoredProcedure);
            return true;
        }



    }

}
