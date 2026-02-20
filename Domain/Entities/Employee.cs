using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Entities
{
	public class Employee
	{
		[Key]
		public Guid Id { get; set; }
		public string Name { get; set; } = null!;
		public string? Email { get; set; }

		public string Phone { get; set; } = null!;
		public ICollection<EmployeeQualification> EmployeeQualifications { get; set; } 
	}
}
