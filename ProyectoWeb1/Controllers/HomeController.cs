using ProyectoWeb1.Models;
using ProyectoWeb1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoWeb1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //var gestor = new GestorVentas();
            //var listaProductos = gestor.ObtenerProductos();
            //var listaClientes = gestor.ObtenerClientes();

            var venta = new Venta();
            //venta.Clientes = listaClientes;
            //venta.Productos = listaProductos;
            return View("Ventas", venta);
        }
        public ActionResult Alta()
        {
            return View();
        }
        public ActionResult Guardar(Cliente cliente)
        {
            // aqui crear un cliente model que reciba copie los datos del cliente de view model.
            return View("Index");
        }
    }
   
    
    
}