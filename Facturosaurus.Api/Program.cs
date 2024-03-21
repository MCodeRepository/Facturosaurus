using Facturosaurus.Api.Entities;
using Facturosaurus.Api.Middleware;
using Facturosaurus.Api.Models.Validators;
using Facturosaurus.Api.Models;
using Facturosaurus.Api.Services;
using Facturosaurus.Api;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using AutoMapper;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using System.Reflection;

//////////////////////////////////////
// Code from ConfigureServices method
//////////////////////////////////////

var builder = WebApplication.CreateBuilder();

var authenticationSettings = new AuthenticationSettings();

builder.Configuration.GetSection("Authentication").Bind(authenticationSettings);

builder.Services.AddSingleton(authenticationSettings);

builder.Services.AddAuthentication(options =>
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

builder.Services.AddScoped<ErrorHandlingMiddleware>();

builder.Services.AddControllers().AddFluentValidation();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Facturosaurus.Api", Version = "v1" });
});

string connectionString = builder.Configuration.GetConnectionString("FacturosaurusDB");

builder.Services.AddDbContext<FacturosaurusDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddScoped<FacturosaurusSeeder>();

//AutoMapper
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

//PasswordHasher
builder.Services.AddScoped<IPasswordHasher<User>, PasswordHasher<User>>();

//Validators
builder.Services.AddScoped<IValidator<UserRegisterDto>, RegisterUserDtoValidator>();
builder.Services.AddScoped<IValidator<UserNewPasswordDto>, UserNewPasswordDtoValidator>();
builder.Services.AddScoped<IValidator<UserModifyDto>, UserModifyDtoValidator>();
builder.Services.AddScoped<IValidator<CompanyDetailsCreateDto>, CompanyDetailsCreateDtoValidator>();
builder.Services.AddScoped<IValidator<CustomerCreateDto>, CustomerCreateDtoValidator>();
builder.Services.AddScoped<IValidator<CustomerModifyDto>, CustomerModifyDtoValidator>();
builder.Services.AddScoped<IValidator<InvoiceCreateDto>, InvoiceCreateDtoValidator>();
builder.Services.AddScoped<IValidator<InvoiceItemDto>, InvoiceItemDtoValidator>();
//Services
builder.Services.AddScoped<IAccountService, AccountService>();
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IInvoiceService, InvoiceService>();
builder.Services.AddScoped<IReportService, ReportService>();


//////////////////////////////////////
// Code from Configure method
//////////////////////////////////////

var app = builder.Build();
var scope = app.Services.CreateScope();
var seeder = scope.ServiceProvider.GetRequiredService<FacturosaurusSeeder>();


seeder.Seed();

if (app.Environment.IsDevelopment())
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


app.Run();