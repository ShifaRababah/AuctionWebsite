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
    public class AttendRepository: IAttendRepository
    {
        private readonly IDbContext _dbContext;



        public AttendRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }



        public bool CreateAttend(Attend attend)
           {
               var p = new DynamicParameters();
               p.Add("@UerID", attend.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
               p.Add("@StartTime", attend.StartDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
               p.Add("@EndTime", attend.EndDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
               var result = _dbContext.Connection.ExecuteAsync("CreateAttend", p, commandType: CommandType.StoredProcedure);
               return true;
           }
    }
}
