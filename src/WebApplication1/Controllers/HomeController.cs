using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Framework.OptionsModel;
using Microsoft.Framework.Caching.Memory;
using System.Text;
using Microsoft.AspNet.Http;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        MyOptions Options { get; }
        IMemoryCache Cache { get; }

        public HomeController(IOptions<MyOptions> optionsAccessor, IMemoryCache cache)
        {
            Options = optionsAccessor.Options;
            Cache = cache;
        }

        public IActionResult Index()
        {
            Context.Session.SetString("Message", "Hello Session " + DateTime.Now);

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Session: " + Context.Session.GetString("Message");

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
