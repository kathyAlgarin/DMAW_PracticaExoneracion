using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PracticaExoneracion.Models;

namespace PracticaExoneracion.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            ViewData["NombreEstudiante"] = "Katherinne Jeannette Cruz Algarin";
            ViewData["Carrera"] = "Ingeniería en desarrollo de software";
            ViewData["Materia"] = "Desarrollo Multiplataforma de Aplicaciones";
            ViewData["Seccion"] = "A";

            return View("Infoestudiante");
        }

    }
}
