using EmployeeManagement.Models;
using EmployeeManagement.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EmployeeManagement.Controllers
{
	public class HomeController : Controller
	{

		public IService service { get; set; }
        private readonly ILogger<HomeController> _logger;
		public HomeController(IService service, ILogger<HomeController> logger)
		{
			this.service = service;
			_logger = logger;
		}
	
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
        public IActionResult Login()
		{
			return View();
		}

        [HttpPost]
		public IActionResult Login(string email, string password)
		{
           if( service.Login(email, password))
			{
                return RedirectToAction("Index", "Employee");
            }
            return View();
        }

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

	}
}
