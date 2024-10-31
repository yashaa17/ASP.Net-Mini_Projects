using EmployeeManagement.Models;

namespace EmployeeManagement.Repositories
{
	public class EmployeeManager : IEmployeeManager
	{
		public void AddEmployee(Employee employee)
		{
			using (var context = new CollectionContext())
			{
				context.Employees.Add(employee);
				context.SaveChanges();
			}

		}

		public void DeleteEmployee(int id)
		{
			using (var context = new CollectionContext())
			{
				context.Employees.Remove(context.Employees.Find(id));
				context.SaveChanges();
			}
		}

		public List<Employee> GetAll()
		{
			using (var context = new CollectionContext())
			{
				return context.Employees.ToList();
			}
		}

		public Employee GetEmployeeById(int id)
		{
			using (var context = new CollectionContext())
			{
				return (Employee) context.Employees.Find(id);
			}
		}

        public List<Employee> Sort()
        {
            using(var context = new CollectionContext())
			{
				return context.Employees.OrderByDescending(e=>e.name).ToList();
			}
        }

        public void UpdateEmployee(Employee employee)
        {
            using(var context = new CollectionContext())
			{
				var emp = context.Employees.Find(employee.id);
				emp.name= employee.name;
				emp.email= employee.email;
				emp.reg_date= employee.reg_date;
				emp.address	= employee.address;
				emp.mob_num= employee.mob_num;
				emp.password= employee.password;
				context.SaveChanges();
			}
        }
    }
}
