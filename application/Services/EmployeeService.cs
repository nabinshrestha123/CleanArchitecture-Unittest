using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Entities.Interfaces;
using MyApp.Application.DTOs;
using MyApp.Application.Interfaces.Employees;

namespace MyApp.Application.Services
{
	public class EmployeeService : IEmployeeService
	{
		private readonly IEmployeeJoinRepository _employeeRepository;

		public EmployeeService(IEmployeeJoinRepository employeeRepository)
		{
			_employeeRepository = employeeRepository;
		}

		public async Task<EmployeeDto> AddEmployeeAsync(CreateEmployeeDto createEmployeeDto)
		{
			var employee = new Employee
			{
			
				Name = createEmployeeDto.Name,
				Phone = createEmployeeDto.Phone,

			};

			await _employeeRepository.AddEmployeeAsync(employee);

			return new EmployeeDto
			{
			
				Name = employee.Name,
				Phone = employee.Phone
			};
		}

		public async Task<bool> DeleteEmployeeAsync(Guid id)
		{
			var dltemployee= await _employeeRepository.GetEmployeesByIdAsync(id);
			var result=await _employeeRepository.DeleteEmployeeAsync(dltemployee);
			return true;
		}

		public async Task<IEnumerable<EmployeeDto>> GetAllEmployeesAsync()
		{
			var employees = await _employeeRepository.GetAllEmployeesAsync();

			return employees.Select(e => new EmployeeDto
			{
				Id = e.Id,
				Name = e.Name,
				Phone = e.Phone
			}).ToList();
		}

		public async Task<EmployeeDto> GetEmployeesByIdAsync(Guid id)
		{
			var employee = await _employeeRepository.GetEmployeesByIdAsync(id);

			if (employee == null)
				return null;

			return new EmployeeDto
			{
				Id = employee.Id,
				Name = employee.Name,
				Phone = employee.Phone
			};
		}

       

		public async Task<EmployeeDto> UpdateEmployeeAsync(UpdateEmployeeDto updateEmployeeDto)
		{
			var employees = await _employeeRepository.GetEmployeesByIdAsync(updateEmployeeDto.Id);

			if (employees == null)
				return null;
			employees.Id= updateEmployeeDto.Id;
			employees.Name = updateEmployeeDto.Name;
			employees.Phone = updateEmployeeDto.Phone;


			await _employeeRepository.UpdateEmployeeAsync(employees);

			return new EmployeeDto
			{
				Id = employees.Id,
				Name = employees.Name,
				Phone = employees.Phone
			};
		}

        
    }
}
