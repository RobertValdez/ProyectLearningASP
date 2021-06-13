using Microsoft.AspNetCore.Mvc;
using ProyectLearningASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectLearningASP.Controllers
{
    public class EscuelaController : Controller
    {
        public IActionResult Index()
        {
            var escuela = new Escuela();
            escuela.UniqueId = Guid.NewGuid().ToString();
            escuela.Nombre = "Corex VF Learning";
            escuela.AñoDeCreación = 1950;

            escuela.Dirección = "Av Santo Domingo Sabio #6";
            escuela.Ciudad = "Rodrigues Vela";
            escuela.Pais = "Rep. Dom.";

            ViewBag.Lamadre = "JAJAJA";

            return View(escuela);
        }
    }
}
