using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp.Application.DTOs;
using MyApp.Application.Interfaces.Employees;

namespace Myapp.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeQualificationController : ControllerBase
    {
        private readonly IEmployeeQualifications _employeeQualifications;

        public EmployeeQualificationController(IEmployeeQualifications employeeQualifications)
        {
            _employeeQualifications = employeeQualifications;
        }

        [HttpGet]
		public async Task<IEnumerable<EmployeesQualificationDto>> GetAllEmployeesQualificationAsync()
        {
           var qualification= await _employeeQualifications.GetAllEmployeesQualificationAsync();
            return qualification;

		}
        [HttpGet("{id}")]
		public async Task<EmployeesQualificationDto> GetEmployeesQualificationByIdAsync(Guid id)
        {
          var qualification= await _employeeQualifications.GetEmployeesQualificationByIdAsync(id);
            return qualification;
		}
        [HttpPost]
		public async Task<EmployeesQualificationDto> AddEmployeeQualificationAsync(CreateEmployeesQualificationDto createEmployeeQualificationDto)
        {
            var qualification=await _employeeQualifications.AddEmployeeQualificationAsync(createEmployeeQualificationDto);
            return qualification;
		}
        [HttpPut]
		public async Task<EmployeesQualificationDto> UpdateEmployeeQualificationAsync(UpdateEmployeesQualificationDto updateEmployeeQualificationDto) { 
            var qualification= await _employeeQualifications.UpdateEmployeeQualificationAsync(updateEmployeeQualificationDto);
            return qualification;
		}
		[HttpDelete]
		public Task<bool> DeleteEmployeeQualificationAsync(Guid id)
        {
            var result= _employeeQualifications.DeleteEmployeeQualificationAsync(id);
            return result;
		}
	}
}
