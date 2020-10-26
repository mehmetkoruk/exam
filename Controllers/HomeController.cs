using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using examlast.Models;
using Microsoft.AspNetCore.Authorization;

namespace examlast.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            Context mycontext = new Context();
            getdata mydata = new getdata();

            string[] x = mydata.GetData();
            for (int i = 0; i < x.Length; i++)
            {

                mycontext.pmodels.Add(new Pmodel() { PTitle = x[i] });

            }
            mycontext.SaveChanges();
        }
      
        public IActionResult questpage()
        {
            return View("questpage");
        }
        public IActionResult qpage()
        {
            return View("qpage");
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
