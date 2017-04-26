using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWeb1.Models
{
    public class GestorVentas
    {
        public List<Producto> ObtenerProductos()
        {
            var arroz = new Producto("Arroz");
            var harina = new Producto("Harina");
            var azucar = new Producto("Azucar");

            var listaProductos = new List<Producto>();
            listaProductos.Add(arroz);
            listaProductos.Add(harina);
            listaProductos.Add(azucar);
            return listaProductos;
        }

        //public List<Cliente> ObtenerClientes()
        //{
        //    //var cliente = new Cliente("Ledesma", "Facundo");
        //    //var cliente1 = new Cliente("Dip", "Raul");
        //    //var cliente2 = new Cliente("Messi", "Leonel");
        //    //var listaClientes = new List<Cliente>();

        //    //listaClientes.Add(cliente);
        //    //listaClientes.Add(cliente1);
        //    //listaClientes.Add(cliente2);
        //    //return listaClientes;
        //}
    }
}