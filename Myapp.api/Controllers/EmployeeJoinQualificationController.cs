using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp.Application.DTOs;
using MyApp.Application.Interfaces.Employees;

namespace Myapp.api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EmployeeJoinQualificationController : ControllerBase
	{
		private readonly IEmployeeJoinQualification _employeeJoinQualification;
		public EmployeeJoinQualificationController(IEmployeeJoinQualification employeeJoinQualification)
		{
			_employeeJoinQualification = employeeJoinQualification;

		}
		[HttpGet]
		public async Task<IEnumerable<EmployeeJoinQualification>> GetEmployeeLeftJoinQualificationAsync()
		{
			return await _employeeJoinQualification.GetEmployeeLeftJoinQualificationAsync();


		}
		[HttpGet("Inner")]
		public async Task<IEnumerable<EmployeeJoinQualification>> GetEmployeeInnerJoinQualificationAsync()
		{
			return await _employeeJoinQualification.GetEmployeeInnerJoinQualificationAsync();
		}
		[HttpGet("Group")]
		public async Task<IEnumerable<EmployeeJoinQualification>> GetEmployeeGroupJoinQualificationAsync()
		{
			return await _employeeJoinQualification.GetEmployeeGroupJoinQualificationAsync();
		}
		

	}
}