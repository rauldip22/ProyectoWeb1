using ProyectoWeb1.ExtensionClasses;
using ProyectoWeb1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoWeb1.Controllers
{
    public class ProductoController : Controller
    {
        GestorProductos gestor = new GestorProductos();

        // GET: Producto
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Guardar(ViewModel.Producto productoViewModel)
        {

            if (ModelState.IsValid)
            {
                gestor.Guardar(productoViewModel.ConvertirAModelo());
            }
            else
            {
                return View("Alta");
            }
            return RedirectToAction("Listar");
        }

        public ActionResult Alta()
        {
            return View();
        }
        public ActionResult Listar()
        {

            var productos = gestor.Listar();
            return View(productos.ConvertirAViewModel());
        }
    }
}