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
   public class TestimonialRepository: ITestimonialRepository
    {
        private readonly IDbContext _dbContext;



        public TestimonialRepository(IDbContext dbContext)
        {
            _dbContext = dbContext;
        }



        //Create method

        public bool CreateTestimonial(Testimonial testimonial)
        {
            var p = new DynamicParameters();
            p.Add("@Email", testimonial.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Name", testimonial.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Massege", testimonial.Massege, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("CreateTestimonial", p, commandType: CommandType.StoredProcedure);
            return true;
        }

        public List<Testimonial> GetAllTestimonial()
        {


            IEnumerable<Testimonial> result = _dbContext.Connection.Query<Testimonial>("GetAllTestimonial", commandType: CommandType.StoredProcedure);

            return result.ToList();

        }
        public bool DeleteTestimonial(int id)
        {
            var p = new DynamicParameters();
            p.Add("@TestimonialId", id, dbType: DbType.Int32, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("DeleteTestimonial", p, commandType: CommandType.StoredProcedure);






            return true;

        }
        public bool UpdateTestimonial(Testimonial testimonial)
        {
            var p = new DynamicParameters();
            p.Add("@TestimonialId", testimonial.TestimonialId, dbType: DbType.Int32, direction: ParameterDirection.Input);
            p.Add("@Email", testimonial.Email, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Name", testimonial.Name, dbType: DbType.String, direction: ParameterDirection.Input);
            p.Add("@Massege", testimonial.Massege, dbType: DbType.String, direction: ParameterDirection.Input);
            var result = _dbContext.Connection.ExecuteAsync("UpdateTestimonial", p, commandType: CommandType.StoredProcedure);
            return true;
        }
    }
}

