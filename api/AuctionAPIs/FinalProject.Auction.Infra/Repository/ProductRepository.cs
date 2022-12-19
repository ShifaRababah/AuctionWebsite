using Dapper;
using FinalProject.Auction.Core.Common;
using FinalProject.Auction.Core.Data;
using FinalProject.Auction.Core.DTO;
using FinalProject.Auction.Core.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FinalProject.Auction.Infra.Repository
{
   public class ProductRepository : IProductRepository
    {
        private readonly IDbContext _dbContext;

        public ProductRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public bool CreateProduct1(Product product)
        {
            var p = new DynamicParameters();
            p.Add("@Title", product.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@PriceProduct", product.PriceProduct, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@StartDate", product.StartDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@EndDate", product.EndDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@Image", product.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Description",product.Description, dbType: DbType.String, direction: ParameterDirection.Input);

            p.Add("@CategoryId", product.CategoryId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@UserId", product.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Status", product.Status, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.Execute("CreateProduct1", p, commandType: CommandType.StoredProcedure);
            return true;
        }
        public bool CreateProduct(Product product)
        {
            var p = new DynamicParameters();
            p.Add("@Title", product.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@PriceProduct", product.PriceProduct, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@StartDate", product.StartDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@EndDate", product.EndDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@Image", product.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Description", product.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CategoryId", product.CategoryId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@UserId", product.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Status", product.Status= 1, dbType: DbType.Int32, direction: ParameterDirection.Input);
            try {
                
                _dbContext.Connection.ExecuteAsync("CreateProduct", p, commandType: CommandType.StoredProcedure); }
            catch 
            {
                return false;
            }
          
            return true;
        }

        public List<Product> GetAllProduct()
        {
            IEnumerable<Product> result = _dbContext.Connection.Query<Product>("GetAllProduct", commandType: CommandType.StoredProcedure);
            return result.ToList();
        }

        public bool DeleteProduct(int id)
        {
            var p = new DynamicParameters();
            p.Add("@ProductId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("DeleteProduct ", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public bool UpdateProduct(Product product)
        {
            var p = new DynamicParameters();
            p.Add("@ProductId", product.ProductId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Title", product.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@PriceProduct", product.PriceProduct, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@StartDate", product.StartDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@EndDate", product.EndDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@Image", product.Image, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Description", product.Description, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@CategoryId", product.CategoryId, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@UserId", product.UserId, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Status", product.Status =1 , dbType: DbType.String, direction: ParameterDirection.Input);

            var result = _dbContext.Connection.ExecuteAsync("UpdateProduct", p, commandType: CommandType.StoredProcedure);
            return true;
        }


 

        public List<Product> SearchForProduct(Product product)
        {
            //This Proc to search about Products by their names
            var p = new DynamicParameters();
            p.Add("@Title", product.Title, dbType: DbType.String, direction: ParameterDirection.Input);

            IEnumerable<Product> result = _dbContext.Connection.Query<Product>("SearchForProduct", p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public List<Product> SearchForProductByStartAndEndDate(Product product)
        {
            //This Proc to search about Products by interval
            var p = new DynamicParameters();
            p.Add("@StartDate", product.StartDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@EndDate", product.EndDate, dbType: DbType.DateTime, direction: ParameterDirection.Input);

            IEnumerable<Product> result = _dbContext.Connection.Query<Product>("SearchForProductByStartAndEndDate", p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public List<Product> GetAllAuctionAndProduct()
        {
            //This Proc to Get All Info about Auction and Product
            IEnumerable<Product> result = _dbContext.Connection.Query<Product>("GetAllAuctionAndProduct", commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public CountproductDTO Countproduct()
        {
            var result = _dbContext.Connection.Query<CountproductDTO>("Countproduct", commandType: CommandType.StoredProcedure);
            return result.SingleOrDefault();
        }

        public GetProductByIdDTO GetProductById(GetProductByIdDTO getProduct)
        {
            var p = new DynamicParameters();
            p.Add("@productId", getProduct.ProductId, dbType: DbType.Int32, direction: ParameterDirection.Input);


            var result = _dbContext.Connection.Query<GetProductByIdDTO>("GetProductById", p, commandType: CommandType.StoredProcedure);

            return result.SingleOrDefault();
        }

        public List<GetProductUserIdDTO> GetProductUserId(GetProductUserIdDTO pro)
        {
            var p = new DynamicParameters();
            p.Add("@userId", pro.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);


            IEnumerable<GetProductUserIdDTO> result = _dbContext.Connection.Query<GetProductUserIdDTO>("GetProductUserId", p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

        public bool ApprovalSell(ApprovalSellDTO product)
        {
            var p = new DynamicParameters();
            p.Add("@productId", product.productId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@total", product.total, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@date", product.date = DateTime.Now, dbType: DbType.DateTime, direction: ParameterDirection.Input);
            p.Add("@status", product.status = 0, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@profits", product.profits, dbType: DbType.Double, direction: ParameterDirection.Input);
            p.Add("@Userid", product.userid, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Title", product.Title, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Image", product.image, dbType: DbType.String, direction: ParameterDirection.Input);





            try
            {

                _dbContext.Connection.ExecuteAsync("ApprovalSell", p, commandType: CommandType.StoredProcedure);
            }
            catch
            {
                return false;
            }

            return true;
        }



        public List<GetCartByUserIdDTO> GetCartByUserId(GetCartByUserIdDTO pro)
        {
            var p = new DynamicParameters();
            p.Add("@userId", pro.UserId, dbType: DbType.Int32, direction: ParameterDirection.Input);


            IEnumerable<GetCartByUserIdDTO> result = _dbContext.Connection.Query<GetCartByUserIdDTO>("GetCartByUserId", p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }
        public List<PurchasesInfoDTO> GetOrderbyUserID(PurchasesInfoDTO pro1)
        {
            var p = new DynamicParameters();
            p.Add("@UserId", pro1.userid, dbType: DbType.Int32, direction: ParameterDirection.Input);


            IEnumerable<PurchasesInfoDTO> result = _dbContext.Connection.Query<PurchasesInfoDTO>("GetOrderbyUserID", p, commandType: CommandType.StoredProcedure);

            return result.ToList();
        }

    }
}
