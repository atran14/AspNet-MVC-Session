using System;
using AspNet_MVC_Session.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNet_MVC_Session.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Details()
        {
            Member m = new Member
            {
                FirstName = "Van A",
                LastName = "Nguyen",
                Gender = 'M',
                DOB = new DateTime(1993, 10, 15),
                PhoneNumber = "0986667777",
                BirthPlace = "Ha Noi",
                StartDate = new DateTime(2015, 8, 12),
                EndDate = new DateTime(2020, 3, 1)
            };
            return View(m);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Member member)
        {
            if (ModelState.IsValid)
            {
                
            }
            return View(member);
        }
    }
}