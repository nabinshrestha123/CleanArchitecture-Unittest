using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.Entities
{
    public class EmployeeQualification
    {
        [Key]
        public Guid Id { get; set; }
        public string? Experience { get; set; }
        public string? Qualification { get; set; }
		public string? University { get; set; }  
		public string? Skills{ get; set; }

        [ForeignKey("Employee")]
		public Guid EmployeeId { get; set; }
		public virtual Employee Employee { get; set; }

      
    }
}