using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities.Interfaces
{
    public interface IEmployeeQualification
    {
		Task<IEnumerable<EmployeeQualification>> GetAllEmployeesQualificationAsync();
		Task<EmployeeQualification> GetEmployeesQualificationByIdAsync(Guid id);
		public Task<EmployeeQualification> AddEmployeeQualificationAsync(EmployeeQualification employeeQualification);
		public Task<EmployeeQualification> UpdateEmployeeQualificationAsync(EmployeeQualification employeeQualification);
		Task<bool> DeleteEmployeeQualificationAsync(EmployeeQualification employeeQualification);
	}
}
