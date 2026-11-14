using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UKWMgrShop.DAL;
using UKWMgrShop.Models;

namespace UKWMgrShop.Controllers
{
    public class HomeController : Controller
    {
        FilmsContext db;

        public HomeController(FilmsContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var allCategories = db.Categories.ToList();

            return View(allCategories);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
