using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Domain.Entities.Interfaces;
using Microsoft.EntityFrameworkCore.Diagnostics;
using MyApp.Application.DTOs;
using MyApp.Application.Interfaces.Employees;

namespace MyApp.Application.Services
{
    public class EmployeesQualificationService:IEmployeeQualifications
    {
      private readonly IEmployeeQualification _employeeQualificationRepository;
    public EmployeesQualificationService(IEmployeeQualification employeeQualificationRepository)
        {
            _employeeQualificationRepository = employeeQualificationRepository;
		}
		public async Task<IEnumerable<EmployeesQualificationDto>> GetAllEmployeesQualificationAsync()
		{
		var qualifications=await _employeeQualificationRepository.GetAllEmployeesQualificationAsync();
	    return qualifications.Select(q=>new EmployeesQualificationDto
		{
			Id=q.Id,
			Experience=q.Experience,
			Qualification=q.Qualification,
			Skills=q.Skills
		});

		}
		public async Task<EmployeesQualificationDto> GetEmployeesQualificationByIdAsync(Guid id){
			var qualification=await _employeeQualificationRepository.GetEmployeesQualificationByIdAsync(id);
			if(qualification==null) return null;
			return new EmployeesQualificationDto
			{
				Id=qualification.Id,
				Experience=qualification.Experience,
				Qualification=qualification.Qualification,
				Skills=qualification.Skills
			};
		}
		public async Task<EmployeesQualificationDto> AddEmployeeQualificationAsync(CreateEmployeesQualificationDto createEmployeeQualificationDto)
		{
			var qualification = new EmployeeQualification
			{
				Experience = createEmployeeQualificationDto.Experience,
				Qualification = createEmployeeQualificationDto.Qualification,
				Skills = createEmployeeQualificationDto.Skills,
				EmployeeId = createEmployeeQualificationDto.EmployeeId
			};
			await _employeeQualificationRepository.AddEmployeeQualificationAsync(qualification);
			return new EmployeesQualificationDto
			{
				Id = qualification.EmployeeId,
				Experience = qualification.Experience,
				Qualification = qualification.Qualification,
				Skills = qualification.Skills
			};

		}
		public async Task<EmployeesQualificationDto> UpdateEmployeeQualificationAsync(UpdateEmployeesQualificationDto updateEmployeeQualificationDto)
		{
			var qualification=await _employeeQualificationRepository.GetEmployeesQualificationByIdAsync(updateEmployeeQualificationDto.Id);
			if(qualification==null) return null;
			qualification.Experience = updateEmployeeQualificationDto.Experience;
			qualification.Qualification = updateEmployeeQualificationDto.Qualification;
			qualification.Skills = updateEmployeeQualificationDto.Skills;

			var qualificationUpdateResponse = await _employeeQualificationRepository.UpdateEmployeeQualificationAsync(qualification);
			if(qualificationUpdateResponse is null) return null;

			return new EmployeesQualificationDto
			{
				Id = qualificationUpdateResponse.Id,
				Experience = qualificationUpdateResponse.Experience,
				Qualification = qualificationUpdateResponse.Qualification,
				Skills = qualificationUpdateResponse.Skills
			};

		}
		public async Task<bool> DeleteEmployeeQualificationAsync(Guid id)
		{
			var dltqualification =await _employeeQualificationRepository.GetEmployeesQualificationByIdAsync(id);
			var result=await _employeeQualificationRepository.DeleteEmployeeQualificationAsync(dltqualification);
		
			return true;

		}
	}
}
