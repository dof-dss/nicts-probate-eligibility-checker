﻿using eligibility_checker.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eligibility_checker.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            PageModel model = new PageModel();

            model.Header = "Menu";

            PageViewModel viewModel = new PageViewModel(model);

            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Accessibility()
        {
            PageModel model = new PageModel();

            model.Header = "Accessibility";

            PageViewModel viewModel = new PageViewModel(model);

            return View(viewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}