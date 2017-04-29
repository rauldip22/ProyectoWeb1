using ProyectoWeb1.Models.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWeb1.Models
{
    public class GestorClientes
    {
        RepositorioClientes repo = new RepositorioClientes();
        public void Guardar(Cliente cliente)
        {
            repo.Guardar(cliente);
        }

        public List<Cliente> Listar()
        {
            return repo.Listar();
        }
    }    
}