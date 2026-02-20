using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Domain.Entities;

namespace MyApp.Application.DTOs
{
    public class EmployeesQualificationDto
    {
	
		public Guid Id { get; set; }
		public string Experience { get; set; }
		public string Qualification { get; set; }
		
		public string Skills { get; set; }

	}
	public class CreateEmployeesQualificationDto
	{
		public string Experience { get; set; }
		public string Qualification { get; set; }
		
		public string Skills { get; set; }
		public Guid EmployeeId { get; set; }

	}
	public class UpdateEmployeesQualificationDto {
		public Guid Id { get; set; }
		public string? Experience { get; set; }
		public string? Qualification { get; set; }
		
		public string? Skills { get; set; }
	}
}
