using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bisnes.Security;
using Bisnes.Security.Contract.InterfaceBines;
using Data.Security;
using Data.Security.Contract.InterfacesDataLaibery;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Pomelo.EntityFrameworkCore.MySql;

namespace InvestigacionWebApiDemo
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
            string strConetUsers = "server=localhost;port=3306;database=seguridad;user=root;password=osoosa123";

            
            
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "InvestigacionWebApiDemo", Version = "v1" });
            });

            services.AddDbContext<SecurityDbContext>(option =>
                option.UseMySql(strConetUsers, ServerVersion.AutoDetect(strConetUsers),
                    b => b.MigrationsAssembly("InvestigacionWebApiDemo"))
                );
            //Seguridad Data
            services.AddScoped<ILoginAhut, LoginAhut>();

            //Seguridad Bisnes
            services.AddScoped<ILogin, Login>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "InvestigacionWebApiDemo v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}