using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PracticaExoneracion.Models;

namespace PracticaExoneracion.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
