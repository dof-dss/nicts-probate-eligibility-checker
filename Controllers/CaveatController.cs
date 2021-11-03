using eligibility_checker.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace eligibility_checker.Controllers
{
    public class CaveatController : Controller
    {
        private readonly IWebHostEnvironment _env;

        public CaveatController(IWebHostEnvironment env)
        {
            _env = env;
        }

        [HttpGet]
        public IActionResult Index(string page)
        {
            ViewBag.ServiceName = "Apply for Caveat";

            if (string.IsNullOrWhiteSpace(page))
            {
                // Start
                var model = GetPage("start");
                var viewModel = new PageViewModel(model);
                return View(model.Template, viewModel);

            }
            else
            {
                if (page == "solicitor-redirect")
                {
                    return Redirect(Helpers.HelperMethods.GetSolicitorLinkCaveat(_env.EnvironmentName));
                }

                if (page == "citizen-redirect")
                {
                    return Redirect(Helpers.HelperMethods.GetCitizenLinkCaveat(_env.EnvironmentName));
                }

                var model = GetPage(page);
                var viewModel = new PageViewModel(model);

                return View(model.Template, viewModel);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(bool answer, string page)
        {
            ViewBag.ServiceName = "Apply for Caveat";

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
            ViewBag.ServiceName = "Check eligibility";

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
            var folderDetails = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot//{"config//CaveatQuestions.json"}");
            var json = System.IO.File.ReadAllText(folderDetails);
            var list = JsonConvert.DeserializeObject<List<PageModel>>(json);
            return list;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            ViewBag.ServiceName = "Apply for Caveat";
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
