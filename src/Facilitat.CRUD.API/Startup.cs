﻿using System.Data;
using System.Data.SqlClient;
using Facilitat.CRUD.Application.AppServices;
using Facilitat.CRUD.Application.Interfaces.Services;
using Facilitat.CRUD.Domain.Aggregates.Answer.Interfaces.Repository;
using Facilitat.CRUD.Domain.Aggregates.Answer.Interfaces.Services;
using Facilitat.CRUD.Domain.Aggregates.Answer.Services;
using Facilitat.CRUD.Domain.Aggregates.ServiceOrder.Interfaces.Repository;
using Facilitat.CRUD.Domain.Aggregates.ServiceOrder.Interfaces.Services;
using Facilitat.CRUD.Domain.Aggregates.ServiceOrder.Services;
using Facilitat.CRUD.Domain.Aggregates.Template.Interfaces.Repository;
using Facilitat.CRUD.Domain.Aggregates.Template.Interfaces.Services;
using Facilitat.CRUD.Domain.Aggregates.Template.Services;
using Facilitat.CRUD.Infra.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Facilitat.CRUD.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors();
            services.AddControllers();
            services.AddTransient<ITemplateAppService, TemplateAppService>();
            services.AddTransient<ITemplateService, TemplateService>();
            services.AddTransient<ITemplateRepository, TemplateRepository>();

            services.AddTransient<IServiceOrderAppService, ServiceOrderAppService>();
            services.AddTransient<IServiceOrderService, ServiceOrderService>();
            services.AddTransient<IServiceOrderRepository, ServiceOrderRepository>();

            services.AddTransient<IAnswerAppService, AnswerAppService>();
            services.AddTransient<IAnswerService, AnswerService>();
            services.AddTransient<IAnswerRepository, AnswerRepository>();

            services.AddTransient<IQuestionAppService, QuestionAppService>();
            services.AddTransient<IQuestionService, QuestionService>();
            services.AddTransient<IQuestionRepository, QuestionRepository>();

            services.AddSingleton<IConfiguration>(Configuration);
            string connectionString = Configuration.GetConnectionString("DefaultConnection");
            services.AddTransient<IDbConnection>((sp) => new SqlConnection(connectionString));

            services.Configure<StaticFileOptions>(options =>
            {
                options.DefaultContentType = "application/javascript";
            });

            services.AddSwaggerGen();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(builder =>
            {
                builder.WithOrigins("https://localhost:5001", "http://localhost:8080")
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action}/{id?}");
            });

            app.UseSwagger();

            app.UseSwaggerUI();

        }
    }
}

