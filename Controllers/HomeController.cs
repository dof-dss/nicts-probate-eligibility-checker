using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using eligibility_checker.Models;
using Newtonsoft.Json;
using System.IO;

namespace eligibility_checker.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
    
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string page)
        {
            if(string.IsNullOrWhiteSpace(page)){
                // Start
                var model = GetPage("start");               
                var viewModel = new PageViewModel(model);
                return View(model.Template, viewModel);

            }else{
                var model = GetPage(page);
                var viewModel = new PageViewModel(model);
                return View(model.Template, viewModel);
            }
        }

        
        [HttpPost]
        public IActionResult Index(bool answer, string page)
        {
            var source = GetPage(page);
            if(answer){
                return RedirectToAction("Index", new {page = source.OnYes});
            }
            else{
                 return RedirectToAction("Index", new {page = source.OnNo});
            }
        }

        private PageModel GetPage(string page){
            
            var list = GetPages();
            return list.First(item => item.Page.ToLower() == page.ToLower());
        }

        private List<PageModel> GetPages(){
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
