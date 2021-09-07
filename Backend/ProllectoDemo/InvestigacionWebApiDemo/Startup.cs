using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bisnes.Security;
using Bisnes.Security.Contract.InterfaceBines;
using Data.Security;
using Data.Security.Contract.InterfacesDataLaibery;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Pomelo.EntityFrameworkCore.MySql;
using InvestigacionWebApiDemo.Services;
using Bines.Security.Contract.InterfaceBines;

namespace InvestigacionWebApiDemo
{
    public class Startup
    {
        private readonly string LocalPolicy = "LocalPolicy";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: LocalPolicy,
                    bulder => {
                        bulder.WithOrigins("http://localhost:8080")
                            .AllowAnyMethod().AllowAnyHeader();
                    });
            });
            var key = "This is the demo key";
            services.AddRouting(options => options.LowercaseUrls = true);
            services.AddControllers()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.IgnoreNullValues = true;
                    options.JsonSerializerOptions.WriteIndented = true;
                });
            services
                .AddAuthentication(x =>
                {
                    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(x =>
                {
                    x.RequireHttpsMetadata = false;
                    x.SaveToken = true;
                    x.TokenValidationParameters = new TokenValidationParameters
                    {
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(key)),
                        ValidateAudience = false,
                        ValidateIssuerSigningKey = true,
                        ValidateIssuer = false
                    };
                });
            services.AddAuthorization();

            string strConetUsers = "server=localhost;port=3306;database=seguridad;user=root;password=pertenencia1.";

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "InvestigacionWebApiDemo", Version = "v1" });
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Please insert JWT with Bearer into field",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement {
                   {
                     new OpenApiSecurityScheme
                     {
                       Reference = new OpenApiReference
                       {
                         Type = ReferenceType.SecurityScheme,
                         Id = "Bearer"
                       }
                      },
                      new string[] { }
                    }
                  });
            });

            services.AddDbContext<SecurityDbContext>(option =>
                option.UseMySql(strConetUsers, ServerVersion.AutoDetect(strConetUsers),
                    b => b.MigrationsAssembly("InvestigacionWebApiDemo"))
                );
            //Seguridad Data
            services.AddScoped<ILoginAhut, LoginAhut>();
            services.AddScoped<ILogUP, LogUp>();
            services.AddScoped<IUsusario, PerfilesUsuarios>();

            //Seguridad Bisnes
            services.AddScoped<ILogin, Login>();
            services.AddScoped<ILogUPNewUser, LogUpNewUsuario>();
            services.AddScoped<IUsuarioBisnes, UsariosYPermisoso> ();

            //Servicios 
            services.AddSingleton<IJwtAuthenticationService>(new JwtAuthenticationService(key));
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
            app.UseCors(LocalPolicy);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
