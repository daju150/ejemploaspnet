using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC1.Controllers{

    public class SegurosController : Controller{
        // GET: Seguros
        public ActionResult Index(){
            return View();
        }

        // GET: Seguros
        public ActionResult Buscar(){
            //Recueramos en parametro del valor nombreSeguro
            String nombreSeguro = RouteData.Values["nombreSeguro"].ToString();
            nombreSeguro = Server.HtmlEncode(nombreSeguro);
            //Declaramos una vairable para mostrar el resultado
            String resultado = String.Empty;

            switch (nombreSeguro){
                case "PC": { resultado = "Disponible 4 unidades";break; }
                case "RAM":{ resultado = "Disponible 2 unidades";break; }
                default: { resultado = String.Format("El producto {0} no existe en strock", nombreSeguro); break;}
            }


            return Content("<p>" + resultado + "</p>");
        }

    }
}