using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UKWMgrShop.Models;

namespace UKWMgrShop.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
