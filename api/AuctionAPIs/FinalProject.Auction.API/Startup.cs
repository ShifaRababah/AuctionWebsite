using FinalProject.Auction.Core.Common;
using FinalProject.Auction.Core.Repository;
using FinalProject.Auction.Core.Service;
using FinalProject.Auction.Core.Services;
using FinalProject.Auction.Infra.Common;
using FinalProject.Auction.Infra.Repository;
using FinalProject.Auction.Infra.Service;
using FinalProject.Auction.Infra.Services;
using FinalProject1.Auction1.Core.Repository;
using FinalProject1.Auction1.Core.Service;
using FinalProject1.Auction1.Infra.Repository;
using FinalProject1.Auction1.Infra.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.Auction.API
{
    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
options.AddPolicy(name: MyAllowSpecificOrigins, builder =>
{
    builder.AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader();
}));
            services.AddControllers();
            services.AddScoped<IDbContext, DbContext>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ICartRepository, CartRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<ICustomerRepository, CustomerRepository>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICartService, CartService>();
            services.AddScoped<IEmployeeService, EmployeeService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IAuctionRepository, AuctionRepository>();
            services.AddScoped<IAuctionService, AuctionService>();
            services.AddScoped<IBankService, BankService>();
            services.AddScoped<IBankRepository, BankRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IHomePageRepository, HomePageRepository>();
            services.AddScoped<IAttendRepository, AttendRepository>();
            services.AddScoped<ITestimonialRepository, TestimonialRepository>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ITestimonialService, TestimonialService>();
            services.AddScoped<IAttendService, AttendService>();
            services.AddScoped<IHomePageService, HomePageService>();
            services.AddScoped<IJWTRepository, JWTRepository>();
            services.AddScoped<IJWTService, JWTService>();




        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseCors(x => x
.AllowAnyMethod()
.AllowAnyHeader()
.SetIsOriginAllowed(origin => true) // allow any origin
.AllowCredentials()); // allow credentials
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseStaticFiles();
            app.UseCors();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
