using ProyectoWeb1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWeb1.Models.AccesoDatos
{
    public class RepositorioClientes
    {
        ABMDatabaseEntities tallerDB = new ABMDatabaseEntities();
        public RepositorioClientes()
        {
            tallerDB.Database.Log = Logger.Log;
        }
        public void Guardar(Cliente cliente)
        {

            tallerDB.Cliente.Add(cliente);
            tallerDB.SaveChanges();
        }

        

        public List<Cliente> Listar()
        {
            return tallerDB.Cliente.ToList();
        }
        public void Eliminar(int id)
        {
            //tallerDB.Cliente.Remove
        }

        public List<Cliente> Buscar(string cliente)
        {
            var resultadoBusqueda = tallerDB.Cliente.Where(x => x.Apellido.Contains(cliente) || x.Nombre.Contains(cliente));
            return resultadoBusqueda.ToList();
        }

        public void Eliminar(string apellido, string nombre)
        {
            tallerDB.Cliente.Where(x => x.Apellido == apellido && x.Nombre == nombre).First();
        }
    }
}