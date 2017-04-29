using ProyectoWeb1.ExtensionClasses;
using ProyectoWeb1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoWeb1.Controllers
{
    public class ClientesController : Controller
    {
        GestorClientes gestor = new GestorClientes();

        // GET: Clientes
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Alta()
        {
            return View();
        }
        public ActionResult Guardar(ViewModel.Cliente clienteViewModel)
        {
            
            if (ModelState.IsValid)
            {
                gestor.Guardar(clienteViewModel.ConvertirAModelo());
            }
            else
            {
                return View("Alta");
            }
            return RedirectToAction("Listar");
        }
        public ActionResult Listar()
        {
     
            var clientes = gestor.Listar();
            return View(clientes.ConvertirAViewModel());
        }
    }
}