using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASpNETCore2.Models;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace ASpNETCore2.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}