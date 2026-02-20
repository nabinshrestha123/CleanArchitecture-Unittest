using Microsoft.EntityFrameworkCore;



namespace Domain.Entities.Interfaces
{
	public interface IEmployeeJoinRepository
	{

		
		public Task<bool> UpdateEmployeeAsync(Employee entity);
		public Task<bool> DeleteEmployeeAsync(Employee entity);
		public Task<Employee> GetEmployeesByIdAsync(Guid id);
		public Task<Employee> AddEmployeeAsync(Employee entity);
		Task<IEnumerable<Employee>> GetAllEmployeesAsync();
		//      Task<bool> DeleteEmployeeAsync(Employee entity);
		//      Task UpdateEmployeeAsync(Employee employee);
	}

}

