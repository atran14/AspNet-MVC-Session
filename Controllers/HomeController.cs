using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AspNet_MVC_Session.Models;

namespace AspNet_MVC_Session.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public static List<Role> roleList = new List<Role>();
        public static List<User> userList = new List<User>();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;

            roleList.Add(new Role
            {
                Id = 0,
                Name = "Admin"
            });
            roleList.Add(new Role
            {
                Id = 1,
                Name = "Visitor"
            });

            userList.Add(new User
            {
                Id = 0,
                Username = "admin",
                Password = "12"
            });
            userList.Add(new User
            {
                Id = 1,
                Username = "notAdmin",
                Password = "1"
            });
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
