using System;
using Microsoft.Extensions.DependencyInjection;  // ✅ ADD THIS LINE
using Microsoft.Extensions.Configuration;        // ✅ ADD THIS TOO

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using MyApp.Application.Interfaces.Employees;
using MyApp.Application.Services;

namespace application
{
    public static class DependencyInjection
    {
        public static IServiceCollection  AddApplicationDI(this IServiceCollection services)
        {
            services.AddScoped<IEmployeeService, EmployeeService>();
           
            return services;
        }
    } 
}
 