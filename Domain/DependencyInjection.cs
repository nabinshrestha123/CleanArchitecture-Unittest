using System;
using Microsoft.Extensions.DependencyInjection;  // ✅ ADD THIS LINE
using Microsoft.Extensions.Configuration;        // ✅ ADD THIS TOO

using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public static class DependencyInjection
    {
		public static IServiceCollection AddDomainDI(this IServiceCollection services)
		{
			ArgumentNullException.ThrowIfNull(services);
			return services;
		}
	}
}
