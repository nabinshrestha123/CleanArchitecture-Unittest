using System;
using System.Collections.Generic;
using System.Text;

using MyApp.Application.DTOs;
namespace MyApp.Application.Interfaces.Employees
{
    public interface IEmployeeQualifications
    {
        Task<IEnumerable<EmployeesQualificationDto>> GetAllEmployeesQualificationAsync();
        Task<EmployeesQualificationDto> GetEmployeesQualificationByIdAsync(Guid id);
        public Task<EmployeesQualificationDto> AddEmployeeQualificationAsync(CreateEmployeesQualificationDto createEmployeeQualificationDto);
        public Task<EmployeesQualificationDto> UpdateEmployeeQualificationAsync(UpdateEmployeesQualificationDto updateEmployeeQualificationDto);
        public Task<bool> DeleteEmployeeQualificationAsync(Guid id);

	}
}
