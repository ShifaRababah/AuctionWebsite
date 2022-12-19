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
   public class CategoryRepository: ICategoryRepository
    {
       
            private readonly IDbContext _dbContext;



            public CategoryRepository(IDbContext dbContext)
            {
                _dbContext = dbContext;
            }



            //Create method

            public bool CreateCategory(Category category)
            {
                var p = new DynamicParameters();
                p.Add("@Name", category.Name, dbType: DbType.String, direction: ParameterDirection.Input);
                
                var result = _dbContext.Connection.ExecuteAsync("CreateCategory", p, commandType: CommandType.StoredProcedure);
                return true;
            }

            public List<Category> GetAllCategory()
            {


                IEnumerable<Category> result = _dbContext.Connection.Query<Category>("GetAllCategory", commandType: CommandType.StoredProcedure);

                return result.ToList();

            }
            public bool DeleteCategory(int id)
            {
                var p = new DynamicParameters();
                p.Add("@CategoryId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
                var result = _dbContext.Connection.ExecuteAsync("DeleteCategory", p, commandType: CommandType.StoredProcedure);






                return true;

            }
            public bool UpdateCategory(Category category)
            {
                var p = new DynamicParameters();
                p.Add("@CategoryId", category.CategoryId, dbType: DbType.Int32, direction: ParameterDirection.Input);
                p.Add("@Name", category.Name, dbType: DbType.String, direction: ParameterDirection.Input);
               
                var result = _dbContext.Connection.ExecuteAsync("UpdateCategory", p, commandType: CommandType.StoredProcedure);
                return true;
            }
        }
}
