using ControlEscolar.Contracts;
using ControlEscolar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ControlEscolar.Controllers
{
    
    public class AlumnosController : Controller
    {
        private readonly IAlumno _alumno;


        public AlumnosController(IAlumno alumno)
        {
            _alumno = alumno;
        } 


        [HttpGet]
        public JsonResult ConsultaAlumnos()
        {
            return new JsonResult(_alumno.ConsultaAlumnos());
        }
        public IActionResult Index()
        {
           /*  Alumno alumno = new Alumno();
            alumno.ConsultaAlumnos(); */
            return View();
        }

        public IActionResult Grupos()
        {
            return View();
        }

        public IActionResult Calificaciones()
        {
            return View();
        }

        public IActionResult RegistrarAspirante()
        {
            return View();
        }
    }
}
