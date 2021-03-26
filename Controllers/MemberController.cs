using System;
using System.Collections.Generic;
using AspNet_MVC_Session.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNet_MVC_Session.Controllers
{
    public class MemberController : Controller
    {
        public static readonly List<Member> MEMBERS_LIST = new List<Member>
        {
            new Member
            {
                FirstName = "Van A",
                LastName = "Nguyen",
                Gender = 'M',
                DOB = new DateTime(1993, 10, 15),
                PhoneNumber = "0986667777",
                BirthPlace = "Ha Noi",
                StartDate = new DateTime(2015, 8, 12),
                EndDate = new DateTime(2020, 3, 1)
            },
            new Member
            {
                FirstName = "Van B",
                LastName = "Nguyen",
                Gender = 'M',
                DOB = new DateTime(1997, 10, 8),
                PhoneNumber = "0961112222",
                BirthPlace = "Ha Noi",
                StartDate = new DateTime(2019, 05, 05),
                EndDate = new DateTime(2020, 01, 01)
            },
            new Member
            {
                FirstName = "Van B",
                LastName = "Tran",
                Gender = 'F',
                DOB = new DateTime(1989, 5, 25),
                PhoneNumber = "0982223333",
                BirthPlace = "TP HCM",
                StartDate = new DateTime(2017, 06, 30),
                EndDate = new DateTime(2020, 02, 10)
            }                
        };

        public IActionResult Details()
        {
            ViewBag.MembersList = MEMBERS_LIST;
            return View();
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