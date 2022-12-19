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
    public class JWTRepository : IJWTRepository
    {
        private readonly IDbContext _dbContext;



        public JWTRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Login Authentication(Login login)
        {
            var p = new DynamicParameters();
            p.Add("@Email", login.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Password", login.Password, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.QueryFirstOrDefault<Login>("AuthLogin", p, commandType: CommandType.StoredProcedure);
            return result;


        }
    }
}
