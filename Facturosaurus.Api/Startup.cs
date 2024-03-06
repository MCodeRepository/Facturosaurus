using AutoMapper;
using Facturosaurus.Api.Entities;
using Facturosaurus.Api.Middleware;
using Facturosaurus.Api.Models;
using Facturosaurus.Api.Models.Validators;
using Facturosaurus.Api.Services;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Net.Http.Headers;
using Microsoft.OpenApi.Models;
using System.Text;

namespace Facturosaurus.Api
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
            var authenticationSettings = new AuthenticationSettings();

            Configuration.GetSection("Authentication").Bind(authenticationSettings);

            services.AddSingleton(authenticationSettings);

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = "Bearer";
                options.DefaultScheme = "Bearer";
                options.DefaultChallengeScheme = "Bearer";
            }).AddJwtBearer(cfg =>
            {
                cfg.RequireHttpsMetadata = false;
                cfg.SaveToken = true;
                cfg.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidIssuer = authenticationSettings.JwtIssuer,
                    ValidAudience = authenticationSettings.JwtIssuer,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(authenticationSettings.JwtKey))
                };

            });

            services.AddScoped<ErrorHandlingMiddleware>();

            services.AddControllers().AddFluentValidation();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Facturosaurus.Api", Version = "v1" });
            });

            string connectionString = Configuration.GetConnectionString("FacturosaurusDB");

            services.AddDbContext<FacturosaurusDbContext>(options => options.UseSqlServer(connectionString));
            services.AddScoped<FacturosaurusSeeder>();

            //AutoMapper
            services.AddAutoMapper(this.GetType().Assembly);

            //PasswordHasher
            services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();

            //Validators
            services.AddScoped<IValidator<UserRegisterDto>, RegisterUserDtoValidator>();
            services.AddScoped<IValidator<UserNewPasswordDto>, UserNewPasswordDtoValidator>();
            services.AddScoped<IValidator<UserModifyDto>, UserModifyDtoValidator>();
            services.AddScoped<IValidator<CompanyDetailsCreateDto>, CompanyDetailsCreateDtoValidator>();
            services.AddScoped<IValidator<CustomerCreateDto>, CustomerCreateDtoValidator>();
            services.AddScoped<IValidator<CustomerModifyDto>, CustomerModifyDtoValidator>();
            services.AddScoped<IValidator<InvoiceCreateDto>, InvoiceCreateDtoValidator>();
            services.AddScoped<IValidator<InvoiceItemDto>, InvoiceItemDtoValidator>();
            //Services
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<ICompanyService, CompanyService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IInvoiceService, InvoiceService>();
            services.AddScoped<IReportService, ReportService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, FacturosaurusSeeder seeder)
        {

            seeder.Seed();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Facturosaurus.Api"));
            }

            app.UseCors(policy => policy.WithOrigins("http://localhost:44372", "https://localhost:44372")
            .AllowAnyMethod()
            .WithHeaders(HeaderNames.ContentType));

            app.UseMiddleware<ErrorHandlingMiddleware>();

            app.UseAuthentication();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
