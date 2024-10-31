using EmployeeManagement.Models;
using EmployeeManagement.Services;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace EmployeeManagement.Controllers
{
	public class EmployeeController : Controller
	{

		public IEmployeeService EmployeeService { get; set; }

		public EmployeeController(IEmployeeService employeeService)
		{
			EmployeeService = employeeService;
		}

		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public IActionResult AddEmployees()
		{

			return View();
		}

		[HttpPost]
		public IActionResult AddEmployees(string name, DateTime reg_date, string address, string mob_num, string email, string password)
		{

			Employee emp = new Employee(name, reg_date, address, mob_num, email, password);
			EmployeeService.AddEmployee(emp);
			return View();

		}

		[HttpGet]
		public IActionResult DeleteEmployee()
		{
			return View();
		}

		[HttpPost]
		public IActionResult DeleteEmployee(int id)
		{
			EmployeeService.DeleteEmployee(id);
			return View();
		}

		[HttpGet]
		public IActionResult GetEmployees()
		{
			var emp = EmployeeService.GetAll();
			ViewData["catalog"] = emp;
			return View();
		}

		[HttpGet]
		public IActionResult GetEmployeeById()
		{
			return View();
		}

		[HttpPost]
		public IActionResult GetEmployeeById(int id)
		{
			var emp = EmployeeService.GetEmployeeById(id);
			ViewData["id"] = emp;
			return View();
		}


		[HttpGet]
		public IActionResult Update()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Update(int id, string name, DateTime reg_date, string address, string mob_num, string email, string password)
		{
			var emp = new Employee(id, name, reg_date, address, mob_num, email, password);
			EmployeeService.UpdateEmployee(emp);
			return View();
		}


		[HttpGet]
		public IActionResult Sort()
		{
			List<Employee> emp = EmployeeService.Sort();
			ViewData["sort"] = emp;
			return View();
		}


	}
}