using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DockerizedWebAppDemo.Models;
using Microsoft.Extensions.Options;
using WebAppWithEnvVariables;

namespace DockerizedWebAppDemo.Controllers
{
    public class HomeController : Controller
    {
        private string _message;

        public HomeController(IOptions<MyMessage> options)
        {
            var myMessage = options.Value as MyMessage;
            _message = myMessage.Message;
        }

        public IActionResult Index()
        {
            ViewData["Message"] = $"{_message}";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
