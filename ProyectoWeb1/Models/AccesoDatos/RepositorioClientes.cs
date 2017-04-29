using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWeb1.Models.AccesoDatos
{
    public class RepositorioClientes
    {
        ABMDatabaseEntities1 tallerDB = new ABMDatabaseEntities1();
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
        public void Eliminar(string apellido, string nombre)
        {
            tallerDB.Cliente.Where(x => x.Apellido == apellido && x.Nombre == nombre).First();
        }
    }
}