using Microsoft.AspNetCore.Mvc;
using ProyectLearningASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectLearningASP.Controllers
{
    public class AlumnoController : Controller
    {
        public IActionResult MultiAlumno()
        {
            return View("MultiAlumno", _context.Alumnos);
            //var listaAlumnos = GenerarAlumnosAlAzar();
            //return View("MultiAlumno", listaAlumnos);
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

            //return View(new Alumno
            //{
            //    Nombre = "Pedro",
            //    Id = Guid.NewGuid().ToString()
            //});

            return View(_context.Alumnos.FirstOrDefault());
        }


        //No se usa
        private List<Alumno> GenerarAlumnosAlAzar()
        {
            string[] nombre1 = { "Alba", "Felipa", "Eusebio", "Farid", "Donald", "Alvaro", "Nicolás" };
            string[] apellido1 = { "Ruiz", "Sarmiento", "Uribe", "Maduro", "Trump", "Toledo", "Herrera" };
            string[] nombre2 = { "Freddy", "Anabel", "Rick", "Murty", "Silvana", "Diomedes", "Nicomedes", "Teodoro" };

            var listaAlumnos = from n1 in nombre1
                               from n2 in nombre2
                               from a1 in apellido1
                               select new Alumno { Nombre = $"{n1} {n2} {a1}",
                                   Id = Guid.NewGuid().ToString() };

            return listaAlumnos.OrderBy((al) => al.Id).ToList();
        }

        private EscuelaContext _context;
        public AlumnoController(EscuelaContext context)
        {
            _context = context;
        }
    }
}
