using EmployeeManagement.Models;
using EmployeeManagement.Repositories;

namespace EmployeeManagement.Services
{
	public class EmployeeService : IEmployeeService
	{
		EmployeeManager employeeManager =  new EmployeeManager();
		public void AddEmployee(Employee employee)
		{
			employeeManager.AddEmployee(employee);
		}

        public void DeleteEmployee(int id)
        {
            employeeManager.DeleteEmployee(id);
        }

        public List<Employee> GetAll()
        {
           return employeeManager.GetAll();
        }

        public Employee GetEmployeeById(int id)
        {
            return employeeManager.GetEmployeeById(id);
        }

        public List<Employee> Sort()
        {
           return employeeManager.Sort();
        }

        public void UpdateEmployee(Employee employee)
        {
            employeeManager.UpdateEmployee(employee);
        }
    }
}
