using Green_Basket.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Green_Basket.Controllers
{
    public class AuthController : Controller
    {
        private IUserService _userService;
        public AuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email,string password)
        {
           if(email=="greenBasket@gmail.com" && password =="G@123")
            {
                return RedirectToAction("index", "Home");
            }
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

    }
}
