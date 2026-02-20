using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using MyApp.Application.DTOs;

namespace MyApp.Application.Interfaces.Employees
{
    public  interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync();
		Task <EmployeeDto> GetEmployeesByIdAsync(Guid id);
		public Task<EmployeeDto> AddEmployeeAsync(CreateEmployeeDto createEmployeeDto);
		public Task<EmployeeDto> UpdateEmployeeAsync(UpdateEmployeeDto updateEmployeeDto);
		public Task<bool> DeleteEmployeeAsync(Guid id);
	}
}