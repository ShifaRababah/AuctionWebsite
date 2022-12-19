using Dapper;
using FinalProject.Auction.Core.Common;
using FinalProject.Auction.Core.Data;
using FinalProject.Auction.Core.Repository;
using FinalProject1.Auction1.Core.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FinalProject.Auction.Infra.Repository
{
    public class AuctionRepository: IAuctionRepository
    {

        private readonly IDbContext _dbContext;



        public AuctionRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public List<AuctionnDTO> GetAllAuctionn()
        {
            IEnumerable<AuctionnDTO> result = _dbContext.Connection.Query<AuctionnDTO>("showAcuctionInfo", commandType: CommandType.StoredProcedure);

            return result.ToList();

        }
        public bool  UpdateAuctionPrice(Auctionn auction)
        {
            var p = new DynamicParameters();
           
            p.Add("@Price", auction.Price, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@UserId", auction.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@productId", auction.ProductId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("UpdateAuctionPrice", p, commandType: CommandType.StoredProcedure);


            return true;
        }
    }
}
