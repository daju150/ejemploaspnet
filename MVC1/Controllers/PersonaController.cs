using MVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers{

    public class PersonaController : Controller{
        // GET: Persona
        public ActionResult Persona(){
            Persona obj = new Persona();
            obj.edad = 29;
            obj.nombre = "Daniel";
            obj.apellido = "Arana";
            return View(obj);
        }

        // Form: Persona
        public ActionResult FormularioPersona(){
            return View();
        }

        // GetForm: Persona
        public ActionResult RecibirPersona(){
            Persona obj = new Persona();
            obj.edad = Convert.ToInt32(Request.Form["edad"]);
            obj.nombre = Request.Form["nombre"].ToString();
            obj.apellido = Request.Form["apellido"].ToString();
            return View(obj);
        }

    }
}