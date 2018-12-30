using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Demo.Service;
using Demo.Entity;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        private UserService service;

        public HomeController(UserService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            List<User> users = service.GetAllUsers();
            return View(users);
        }
    }
}