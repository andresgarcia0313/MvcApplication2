using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            List<Persona> listaPersona = new List<Persona>();
            Persona ObjPersona = new Persona
            {
                Codigo = 1,
                Nombre = "Andrés Eduardo",
                ApellidoPaterno = "García",
                ApellidoMaterno = "Márquez"
            };
            Persona ObjPersona1 = new Persona
            {
                Codigo = 2,
                Nombre = "Katherin",
                ApellidoPaterno = "Usa",
                ApellidoMaterno = "Patiño"
            };
            Persona ObjPersona2 = new Persona
            {
                Codigo = 3,
                Nombre = "Yezny Yormary",
                ApellidoPaterno = "García",
                ApellidoMaterno = "Márquez"
            };
            listaPersona.Add(ObjPersona);
            listaPersona.Add(ObjPersona1);
            listaPersona.Add(ObjPersona2);
            return View(listaPersona);
        }
    }
}