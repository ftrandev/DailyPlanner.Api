using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DailyPlanner.Api.Entities;
using DailyPlanner.Api.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DailyPlanner.Api
{
    public class Startup
    {
        
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            //var connectionString = Startup.Configuration["connectionStrings:dailyPlannerDBConnectionString"];
            var connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=DailyPlannerDb;Trusted_Connection=true;";
            services.AddDbContext<DailyPlannerContext>(o => o.UseSqlServer(connectionString));
            services.AddScoped<IDailyPlannerRepository, DailyPlannerRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(DailyPlannerContext dailyPlannerContext,  IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler();
            }

            dailyPlannerContext.EnsureSeedDataForContext();

            app.UseStatusCodePages();

            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Entities.Plan, Models.PlanWithoutBenefitsDto>();
            });

            app.UseMvc();

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
