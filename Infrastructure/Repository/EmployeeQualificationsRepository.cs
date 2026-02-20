using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Domain.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;
using MyApp.Infrastructure.Data;

namespace MyApp.Infrastructure.Repository
{
    public class EmployeeQualificationsRepository(AppDBcontext DbContext): IEmployeeQualification
    {
		public async Task<IEnumerable<EmployeeQualification>> GetAllEmployeesQualificationAsync()
		{
			var employeequalification=await DbContext.EmployeeQualifications.ToListAsync();
			return employeequalification;
		}
		public async Task<EmployeeQualification> GetEmployeesQualificationByIdAsync(Guid id)
		{


			var EmployeeQualificationById=await DbContext.EmployeeQualifications.FirstOrDefaultAsync(x=>x.Id==id);
			return EmployeeQualificationById;
		}
		public async Task<EmployeeQualification> AddEmployeeQualificationAsync(EmployeeQualification employeeQualification)
		{
			DbContext.EmployeeQualifications.AddAsync(employeeQualification);
			await DbContext.SaveChangesAsync();
			return employeeQualification;


		}
		public async Task<EmployeeQualification> UpdateEmployeeQualificationAsync(EmployeeQualification employeeQualification)
		{
			DbContext.EmployeeQualifications.Update(employeeQualification);
			await DbContext.SaveChangesAsync();
			return employeeQualification;
		}
		public async Task<bool> DeleteEmployeeQualificationAsync(EmployeeQualification employeeQualification)
		{
			DbContext.EmployeeQualifications.Remove(employeeQualification);
			await DbContext.SaveChangesAsync();
			return true;

		}

	}



}


