using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Application.DTOs
{
	public class EmployeeJoinQualification
	{
		public string Name { get; set; } = null!;
		public string Phone { get; set; } = null!;
		public Guid Id { get; internal set; }
		public string Experience { get; set; }
		public string Qualification { get; set; }

		public string Skills { get; set; }
		public List<QualifyModel> QualifyModel { get; set; }
	}
	public class QualifyModel
	{
		public string Experience { get; set; }
		public string Qualification { get; set; }

		public string Skills { get; set; }
	}
}
