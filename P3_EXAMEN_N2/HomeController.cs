using Microsoft.AspNetCore.Mvc;

namespace P3_EXAMEN_N2
{
    using Microsoft.AspNetCore.Mvc;
    using P3_EXAMEN_N2.Models;
    using System.Collections.Generic;
    using System.Linq;
    using static global::P3_EXAMEN_N2.Class;

    namespace P3_EXAMEN_N2.Controllers
    {
        public class ProfesorController : Controller
        {
            private static List<Profesor> profesores = new List<Profesor>
        {
            new Profesor { Cedula = "408624242", Nombre = "Juan", Apellido = "Perez", AreaConocimiento = "Matemáticas" },
            new Profesor { Cedula = "405772513", Nombre = "María", Apellido = "González", AreaConocimiento = "Ciencias" }
        };

            public IActionResult Index()
            {
                return View(profesores);
            }

            public IActionResult Buscar(string searchTerm)
            {
                var resultados = profesores.Where(p => p.Nombre.Contains(searchTerm) || p.Apellido.Contains(searchTerm)).ToList();
                return PartialView("_ListaProfesores", resultados);
            }
        }

        public class EstudianteController : Controller
        {
            private static List<Estudiante> estudiantes = new List<Estudiante>
        {
            new Estudiante { Cedula = "403460712", Nombre = "Pedro", Edad = 20, Carrera = "Ingeniería", CantidadCursos = 5 },
            new Estudiante { Cedula = "405600234", Nombre = "Ana", Edad = 22, Carrera = "Medicina", CantidadCursos = 4 }
        };

            public IActionResult Index()
            {
                return View(estudiantes);
            }

            public IActionResult Buscar(string searchTerm)
            {
                var resultados = estudiantes.Where(e => e.Nombre.Contains(searchTerm)).ToList();
                return PartialView("_ListaEstudiantes", resultados);
            }
        }
    }


}
