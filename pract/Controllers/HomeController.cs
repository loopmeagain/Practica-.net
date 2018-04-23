using pract.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace pract.Controllers
{
    public class HomeController : Controller
    {
        public List<Enfermedad> Enfermedades { get; set; }

        public HomeController()
        {
            Enfermedades = new List<Enfermedad>
            {
                new Enfermedad(1, "Cancer", "Enfermedad terminal"),
                new Enfermedad(2, "Sida", "Enfermedad terminal"),
                new Enfermedad(3, "Leucemia", "Enfermedad terminal"),
                new Enfermedad(4, "Lepra", "Enfermedad terminal")
            };
        }

        public ActionResult Index()
        {
            var model = new PacienteModel
            {
                EnfermedadesSelect = new SelectList(GetEnfermedades(), "Id", "Nombre")
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Index(PacienteModel pacienteModel)
        {
            pacienteModel.EnfermedadesSelect = new SelectList(GetEnfermedades(), "Id", "Nombre");
            return View(pacienteModel);
        }

        public List<Enfermedad> GetEnfermedades() => Enfermedades;
    }
}