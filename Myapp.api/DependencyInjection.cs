using System;
using Microsoft.Extensions.DependencyInjection;  // ✅ ADD THIS LINE
using Microsoft.Extensions.Configuration;        // ✅ ADD THIS TOO


using Infrastructure;
using application;

namespace Myapp.api
{
    public static class DependencyInjection
    {
		public static IServiceCollection AddAppDI(this IServiceCollection services)
		{
			services.AddApplicationDI().AddInfrastructureDI();
			ArgumentNullException.ThrowIfNull(services);
			
		
			return services;
		}
	}
}
