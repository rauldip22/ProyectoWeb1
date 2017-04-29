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
    }
}
