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
   public class CartRepository : ICartRepository
    {
        private readonly IDbContext _dbContext;

        public CartRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }



        public bool CreateCart(Cart cart)
        {
            var p = new DynamicParameters();
            p.Add("@Date", cart.Date, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@ProductId", cart.ProductId, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@UserId", cart.UserId, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("CreateCart", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public Cart GetAllCart(int id) { 
        
     
            var p = new DynamicParameters();

            p.Add("@UserId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
          


            var result = _dbContext.Connection.QueryFirstOrDefault<Cart>("GetAllCart", p, commandType: CommandType.StoredProcedure);
            return result;
        }

        public bool DeleteCart(int id)
        {
            var p = new DynamicParameters();
            p.Add("@CartId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("DeleteCart", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}
