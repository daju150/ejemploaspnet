using MVC1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;

namespace MVC1.Controllers{

    public class ProductosController : Controller {

        List<Datos> producto = new List<Datos>();

        public ProductosController(){
            Datos obj1 = new Datos();
            obj1.descripcion = "Manzana";
            obj1.cantidad = 8;
            obj1.precio = 25.20m;
            producto.Add(obj1);

            Datos obj2 = new Datos();
            obj2.descripcion = "Bananas";
            obj2.cantidad = 25;
            obj2.precio = 20.20m;
            producto.Add(obj2);
        }

        // GET: Productos
        public ViewResult MostarProductos(int id){
            Datos obj = producto[id];
            return View(obj);
        }

    }
}