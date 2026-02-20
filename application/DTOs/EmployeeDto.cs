using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MyApp.Application.DTOs
{
    public class EmployeeDto
    {
		public string Name { get; set; } = null!;
		public string Phone { get; set; } = null!;
        public Guid Id { get; internal set; }
    }
	public class UpdateEmployeeDto
	{
        public Guid Id { get; set; }
        public string? Name { get; set; }
		public string? Phone { get; set; } = null!;
	}
	public class CreateEmployeeDto
	{
		public string? Name { get; set; }
		public string? Phone { get; set; } = null!;
		
	}
	
}
