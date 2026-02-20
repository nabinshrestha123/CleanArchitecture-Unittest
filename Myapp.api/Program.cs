using Domain.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using Myapp.api;
using MyApp.Application.Interfaces.Employees;
using MyApp.Application.Services;
using MyApp.Infrastructure.Data;
using MyApp.Infrastructure.Repository;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDBcontext>(options => options.UseNpgsql(
    "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=koeJ2449k"));
// Add services to the container.
builder.Services.AddAppDI();
builder.Services.AddScoped<IEmployeeQualifications, EmployeesQualificationService>();
builder.Services.AddScoped<IEmployeeQualification, EmployeeQualificationsRepository>();
IServiceCollection serviceCollection = builder.Services.AddScoped<IEmployeeJoinQualification, EmployeeJoinQualificationService>();
builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi


//builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
//builder.Services.AddScoped<IEmployeeService, IEmployeeService>();   

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseSwagger();
    app.UseSwaggerUI();

}




app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
