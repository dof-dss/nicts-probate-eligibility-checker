using eligibility_checker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace eligibility_checker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index(string page)
        {
            if (string.IsNullOrWhiteSpace(page))
            {
                // Start
                var model = GetPage("start");
                var viewModel = new PageViewModel(model);
                return View(model.Template, viewModel);

            }
            else
            {
                var model = GetPage(page);
                var viewModel = new PageViewModel(model);
                return View(model.Template, viewModel);
            }
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(bool answer, string page)
        {
            var source = GetPage(page);
            if (answer)
            {
                return RedirectToAction("Index", new { page = source.OnYes });
            }
            else
            {
                return RedirectToAction("Index", new { page = source.OnNo });
            }
        }

        [HttpGet]
        public ActionResult Accessibility()
        {
            var model = GetPage("Accessibility");
            model.Header = "Accessibility";
            var viewModel = new PageViewModel(model);
            return View(viewModel);
        }

        private PageModel GetPage(string page)
        {

            var list = GetPages();
            return list.First(item => item.Page.ToLower() == page.ToLower());
        }

        private List<PageModel> GetPages()
        {
            var folderDetails = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot//{"config//Questions.json"}");
            var json = System.IO.File.ReadAllText(folderDetails);
            var list = JsonConvert.DeserializeObject<List<PageModel>>(json);
            return list;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
