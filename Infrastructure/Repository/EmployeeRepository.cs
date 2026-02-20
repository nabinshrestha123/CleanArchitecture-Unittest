using System.Numerics;
using Domain.Entities;
using Domain.Entities.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MyApp.Infrastructure.Data;

namespace MyApp.Infrastructure.Repository
{
	public class EmployeeRepository(AppDBcontext dbContext) : IEmployeeJoinRepository
	{
		public async Task<IEnumerable<Employee>> GetAllEmployeesAsync()
		{
			return await dbContext.Employees.ToListAsync();
			
		}
		public async Task<Employee> GetEmployeesByIdAsync(Guid id)
		{
			
			return await dbContext.Employees.FirstOrDefaultAsync(x => x.Id == id);
		}
		
		public async Task<Employee> AddEmployeeAsync(Employee entity)
		{

			dbContext.Employees.Add(entity);
			await dbContext.SaveChangesAsync();
			return entity;
			
		}
		public async Task<bool> UpdateEmployeeAsync(Employee entity)
		{
			dbContext.Employees.Update(entity);
			await dbContext.SaveChangesAsync();
			return true;
		}

		public async Task<bool> DeleteEmployeeAsync(Employee entity)
		{
			dbContext.Employees.Remove(entity);
			await dbContext.SaveChangesAsync();
			return true;
		}






	}
}
