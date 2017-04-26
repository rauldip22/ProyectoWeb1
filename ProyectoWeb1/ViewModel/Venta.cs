using ProyectoWeb1.Controllers;
using ProyectoWeb1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWeb1.ViewModel
{
    public class Venta
    {
        public List<Producto> Productos { get; set; }
        public List<Cliente> Clientes { get; set; }
    }
}