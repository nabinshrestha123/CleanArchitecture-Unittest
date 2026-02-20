using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Entities;
using Domain.Entities.Interfaces;
using MyApp.Application.DTOs;
using MyApp.Application.Interfaces.Employees;

namespace MyApp.Application.Services
{
	public class EmployeeJoinQualificationService : IEmployeeJoinQualification
	{
		private readonly IEmployeeJoinRepository _Emp;
		private readonly IEmployeeQualification _Qualification;

		public EmployeeJoinQualificationService(IEmployeeJoinRepository emp, IEmployeeQualification qualification)
		{
			_Emp = emp;
			_Qualification = qualification;
		}
	
		public async Task<IEnumerable<EmployeeJoinQualification>> GetEmployeeLeftJoinQualificationAsync()
		{
			var employees = await _Emp.GetAllEmployeesAsync();
			var qualify = await _Qualification.GetAllEmployeesQualificationAsync();

			if (employees == null) employees = new List<Employee>();
			if (qualify == null) qualify = new List<EmployeeQualification>();

			var JoinResult = from e in employees
							 join q in qualify
								 on e.Id equals q.EmployeeId into empQualify
							 from q in empQualify.DefaultIfEmpty()
							 select new EmployeeJoinQualification
							 {
								 Id = e.Id,
								 Name = e.Name,
								 Phone = e.Phone,
								 Experience = q?.Experience,
								 Qualification = q?.Qualification,
								 Skills = q?.Skills
							 };
			return JoinResult;
		}
		
		public async Task<IEnumerable<EmployeeJoinQualification>> GetEmployeeInnerJoinQualificationAsync()
		{
			var employees = await _Emp.GetAllEmployeesAsync();
			var qualify = await _Qualification.GetAllEmployeesQualificationAsync();
			if (employees == null) employees = new List<Employee>();
			if (qualify == null) qualify = new List<EmployeeQualification>();
			var InnerJoinResult = from e in employees
							 join q in qualify
								 on e.Id equals q.EmployeeId 
							 
							 select new EmployeeJoinQualification
							 {
								 Id = e.Id,
								 Name = e.Name,
								 Phone = e.Phone,
								 Experience = q?.Experience,
								 Qualification = q?.Qualification,
								 Skills = q?.Skills
							 };
			return InnerJoinResult;
		}
		public async Task<IEnumerable<EmployeeJoinQualification>> GetEmployeeGroupJoinQualificationAsync()
		{
			var employees = await _Emp.GetAllEmployeesAsync();
			var qualify = await _Qualification.GetAllEmployeesQualificationAsync();
			if (employees == null) employees = new List<Employee>();
			if (qualify == null) qualify = new List<EmployeeQualification>();
			var GroupJoinResult = from e in employees
								  join q in qualify
									  on e.Id equals q.EmployeeId into empQualify
								  select new EmployeeJoinQualification
								  {
									  Id = e.Id,
									  Name = e.Name,
									  Phone = e.Phone,
									  Experience = empQualify.FirstOrDefault()?.Experience ?? "",
									  Qualification = empQualify.FirstOrDefault()?.Qualification ?? "",
									  Skills = empQualify.FirstOrDefault()?.Skills ?? "",
									  QualifyModel = empQualify.Select(q => new QualifyModel
									  {
										  Qualification = q.Qualification ?? "",
										  Experience = q.Experience ?? "",
										  Skills = q.Skills ?? ""
									  }).ToList()
								  };
			                      
			return GroupJoinResult;
		}
//		var result = from d in departments
//					 join e in employees
//						 on d.Id equals e.DepartmentId into empGroup
//					 select new
//					 {
//						 Department = d.Name,
//						 Employees = empGroup.ToList() // all employees in this department
//					 };

//foreach (var dept in result)
//{
//    Console.WriteLine($"Department: {dept.Department}");
//    foreach (var emp in dept.Employees)
//        Console.WriteLine($"  Employee: {emp.Name}");
//}

}
}