using System;
using Microsoft.Extensions.DependencyInjection;  // ✅ ADD THIS LINE
using Microsoft.Extensions.Configuration;        // ✅ ADD THIS TOO

using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MyApp.Infrastructure.Data;
using Domain.Entities.Interfaces;
using MyApp.Infrastructure.Repository;

namespace Infrastructure
{
   public static class DependencyInjection
    {
		public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
		{
			services.AddDbContext<AppDBcontext>(options =>
			{
				options.UseNpgsql("Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=koeJ2449k");
				
			});
			ArgumentNullException.ThrowIfNull(services);
			services.AddScoped<IEmployeeJoinRepository, EmployeeRepository>();
			return services;
		}
	}
}
