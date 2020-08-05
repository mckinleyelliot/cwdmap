using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cwdmap.Models;
using Microsoft.EntityFrameworkCore;

namespace cwdmap.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
     
        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }
     
        [HttpGet("")]
        public IActionResult Index()
        {
            List<Processor> AllProcessors = dbContext.Processors.ToList();
            ViewBag.ApiKey = "https://maps.googleapis.com/maps/api/js?key=AIzaSyDr42YUsPp9WhD8eoNWXJBpS85Epc0F-xw&callback=myMap";
            return View("Index", AllProcessors);
        }
        
        [HttpGet("new")] 
       public IActionResult New()
        {

            return View();
            
        }
        [HttpPost("create")]
        public IActionResult Create(Processor processor)
        {

                if(ModelState.IsValid)
                {
                    dbContext.Processors.Add(processor);
                    dbContext.SaveChanges();
                    List<Processor> AllProcessors = dbContext.Processors.ToList();
                    return RedirectToAction("Index");
                }
                else
                {
                    return View("New");
                }
            
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

