using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

using Domain;

using IDynamicFormServiceDAL = DAL.IDynamicFormService;
using DynamicFormServiceDAL = DAL.DynamicFormService;
using IDynamicFormServiceBLL = BLL.IDynamicFormService;
using DynamicFormServiceBLL = BLL.DynamicFormService;
using System;
using Domain.Models;
using DynamicFormWeb.ViewModels;
using AutoMapper;
using AutoMapper.Mappers;
using Microsoft.AspNetCore.Http;

namespace DynamicFormWeb
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
            var connectionString = Configuration.GetConnectionString("DynamicFormDatabase");
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));

            services.AddMvc();

            services.AddTransient<IDynamicFormServiceDAL, DynamicFormServiceDAL>();
            services.AddTransient<IDynamicFormServiceBLL, DynamicFormServiceBLL>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}");

                routes.MapRoute(
                    name: "update",
                    template: "{controller=Home}/{action=update}");
            });

            InitializeAutomapper();

        }

        private void InitializeAutomapper()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddConditionalObjectMapper().Where((s, d) => s.Name == d.Name + "ViewModel");
            });
        }
    }
}
