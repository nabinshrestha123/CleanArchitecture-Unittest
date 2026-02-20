using System;
using System.Collections.Generic;
using System.Text;
using MyApp.Application.DTOs;

namespace MyApp.Application.Interfaces.Employees
{
	public interface IEmployeeJoinQualification
	{
		Task<IEnumerable<EmployeeJoinQualification>> GetEmployeeLeftJoinQualificationAsync();
		Task<IEnumerable<EmployeeJoinQualification>> GetEmployeeInnerJoinQualificationAsync();
		Task<IEnumerable<EmployeeJoinQualification>> GetEmployeeGroupJoinQualificationAsync();

	}
}
