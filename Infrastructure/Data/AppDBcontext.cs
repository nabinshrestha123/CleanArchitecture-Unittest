using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MyApp.Infrastructure.Data
{
	public class AppDBcontext(DbContextOptions<AppDBcontext> options) : DbContext(options)
	{
		public DbSet<Employee> Employees { get; set; }
		public DbSet<EmployeeQualification> EmployeeQualifications { get; set; }
	}
}
