using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWeb1.Models.AccesoDatos
{
    public class RepositorioProductos
    {
        ABMDatabaseEntities1 tallerDB = new ABMDatabaseEntities1();
        public void Guardar(Producto producto)
        {
            tallerDB.Producto.Add(producto);
            tallerDB.SaveChanges();
        }
        public List<Producto> Listar()
        {
            return tallerDB.Producto.ToList();
        }
    }
}