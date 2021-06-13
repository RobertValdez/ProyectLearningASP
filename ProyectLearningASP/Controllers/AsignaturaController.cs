using Microsoft.AspNetCore.Mvc;
using ProyectLearningASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectLearningASP.Controllers
{
    public class AsignaturaController : Controller
    {
        public IActionResult MultiAsignatura()
        {
            var listaAsignaturas = new List<Asignatura>(){
                            new Asignatura{Nombre="Matemáticas", 
                                UniqueId = Guid.NewGuid().ToString()},
                            new Asignatura{Nombre="Educación Física",
                                UniqueId = Guid.NewGuid().ToString()},
                            new Asignatura{Nombre="Castellano",
                                UniqueId = Guid.NewGuid().ToString()},
                            new Asignatura{Nombre="Ciencias Naturales",
                                UniqueId = Guid.NewGuid().ToString()},
                            new Asignatura{Nombre="Programación",
                                UniqueId = Guid.NewGuid().ToString()}
                };
            return View(listaAsignaturas);
        }
        public IActionResult Index()
        {
            //var escAsignatura = new Asignatura
            //{
            //    UniqueId = Guid.NewGuid().ToString(),
            //    Nombre = "Programación"
            //};

            //ViewBag.Lamadre = "JAJAJA";
            //ViewBag.Fecha = DateTime.Now;

            return View(new Asignatura
            {
                Nombre = "Programación",
                UniqueId = Guid.NewGuid().ToString()
            });
        }
    }
}
