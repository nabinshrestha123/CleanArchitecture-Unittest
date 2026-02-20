using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp.Application.DTOs;
using MyApp.Application.Interfaces.Employees;

namespace Myapp.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService service)

        {
            _employeeService = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllEmployeesAsync()
        {
            var employees = await _employeeService.GetAllEmployeesAsync();
            return Ok(employees);
        }
        [HttpPost]
        public async Task<IActionResult> AddEmployeeAsync(CreateEmployeeDto createEmployeeDto)
        {
            var employee = await _employeeService.AddEmployeeAsync(createEmployeeDto);
            return Ok(employee);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateEmployeeAsync(UpdateEmployeeDto updateEmployeeDto)
        {
            var updatedEmployee = await _employeeService.UpdateEmployeeAsync(updateEmployeeDto);
            return Ok(updatedEmployee);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployeeAsync(Guid id)
        {
            var deleteemp = await _employeeService.DeleteEmployeeAsync(id);
            return Ok("Delete Successful");


        }
     
			


	}

}