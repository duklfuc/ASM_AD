﻿using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Tranning.Models;

namespace Tranning.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult AdminIndex()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("SessionUsername")))
            {
                return RedirectToAction(nameof(LoginController.Index), "Login");
            }
            return View();
        }

        public IActionResult TrainingStaffIndex()
        {
            if (string.IsNullOrEmpty(HttpContext.Session.GetString("SessionUsername")))
            {
                return RedirectToAction(nameof(LoginController.Index), "Login");
            }
            return View();
        }

        public IActionResult DefaultAction()
        {
            LoginModel model = new LoginModel();
            return View(model);
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