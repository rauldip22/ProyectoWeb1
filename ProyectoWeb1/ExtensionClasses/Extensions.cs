using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWeb1.ExtensionClasses
{
    public static class Extensions
    {
        public static Models.Cliente ConvertirAModelo(this ViewModel.Cliente clienteViewModel)
        {
            var cliente = new Models.Cliente
            {
                Apellido = clienteViewModel.Apellido,
                Nombre = clienteViewModel.Nombre
            };
            return cliente;
        }

    
    public static List<ViewModel.Cliente> ConvertirAViewModel(this List<Models.Cliente> clientes)
    {
        var listaDeViewModel = new List<ViewModel.Cliente>();
        foreach (var clienteDelModelo in clientes)
        {
            var clienteViewModel = new ViewModel.Cliente
            {
                Apellido = clienteDelModelo.Apellido,
                Nombre = clienteDelModelo.Nombre
            };
            listaDeViewModel.Add(clienteViewModel);
        }
        return listaDeViewModel;
    }
        public static Models.Producto ConvertirAModelo(this ViewModel.Producto productoViewModel)
        {
            var producto = new Models.Producto
            {
                Nombre = productoViewModel.Nombre,
                Cantidad = productoViewModel.Cantidad,
                Precio = productoViewModel.Precio

            };
            return producto;
        }


        public static List<ViewModel.Producto> ConvertirAViewModel(this List<Models.Producto> productos)
        {
            var listaDeViewModel = new List<ViewModel.Producto>();
            foreach (var productoDelModelo in productos)
            {
                var productoViewModel = new ViewModel.Producto
                {
                    Nombre = productoDelModelo.Nombre,
                    Cantidad = productoDelModelo.Cantidad,
                    Precio = productoDelModelo.Precio,
                };
                listaDeViewModel.Add(productoViewModel);
            }
            return listaDeViewModel;
        }
    }
}
