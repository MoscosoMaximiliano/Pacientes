using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CapaNegocio;
using Pacientes.Models;

namespace Pacientes.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var respuesta = Hospital.ObtenerPacientes();

            var lista_pacientes = respuesta.Select(x => new Paciente
            {
                ID = x.ID, 
                Nombre = x.Nombre,
                Apellido = x.Apellido,
                Domicilio = x.Domicilio,
                Edad = x.Edad
            }).ToList();

            return View(lista_pacientes);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}