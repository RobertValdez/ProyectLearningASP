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
            //var listaAsignaturas = new List<Asignatura>(){
            //                new Asignatura{Nombre="Matemáticas", 
            //                    Id = Guid.NewGuid().ToString()},
            //                new Asignatura{Nombre="Educación Física",
            //                    Id = Guid.NewGuid().ToString()},
            //                new Asignatura{Nombre="Castellano",
            //                    Id = Guid.NewGuid().ToString()},
            //                new Asignatura{Nombre="Ciencias Naturales",
            //                    Id = Guid.NewGuid().ToString()},
            //                new Asignatura{Nombre="Programación",
            //                    Id = Guid.NewGuid().ToString()}
            //    };

            ViewBag.Fecha = DateTime.Now;
            return View(_context.Asignaturas);
            //return View(listaAsignaturas);
        }
        public IActionResult Index()
        {
            //var escAsignatura = new Asignatura
            //{
            //    UniqueId = Guid.NewGuid().ToString(),
            //    Nombre = "Programación"
            //};

          //  ViewBag.Lamadre = "JAJAJA";
            ViewBag.Fecha = DateTime.Now;

            return View(_context.Asignaturas.FirstOrDefault());

            //return View(new Asignatura
            //{
            //    Nombre = "Programación",
            //    Id = Guid.NewGuid().ToString()
            //});
        }

        private EscuelaContext _context;
        public AsignaturaController(EscuelaContext context)
        {
            _context = context;
        }
    }
}
