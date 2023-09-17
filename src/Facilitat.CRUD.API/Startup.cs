using System.Data;
using System.Data.SqlClient;
using Facilitat.CRUD.Application.AppServices;
using Facilitat.CRUD.Application.Interfaces.Services;
using Facilitat.CRUD.Domain.Aggregates.Template.Interfaces.Repository;
using Facilitat.CRUD.Domain.Aggregates.Template.Interfaces.Services;
using Facilitat.CRUD.Domain.Aggregates.Template.Services;
using Facilitat.CRUD.Infra;
using Facilitat.CRUD.Infra.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Npgsql;

namespace Facilitat.CRUD.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddControllers();
            services.AddTransient<ITemplateAppService, TemplateAppService>();
            services.AddTransient<ITemplateService, TemplateService>();
            services.AddTransient<ITemplateRepository, TemplateRepository>();

            services.AddTransient<IDbConnection>(db => new NpgsqlConnection(Configuration.GetConnectionString("DefaultConnection")));


            services.AddSwaggerGen();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(builder =>
            {
                builder.WithOrigins("https://localhost:5001")
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action}/{id?}");
            });

            

            app.UseSwagger();

            app.UseSwaggerUI();

        }
    }
}

