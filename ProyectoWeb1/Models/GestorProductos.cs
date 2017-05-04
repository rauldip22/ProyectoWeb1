using ProyectoWeb1.Models.AccesoDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoWeb1.Models
{
    public class GestorProductos
    {
        RepositorioProductos repo = new RepositorioProductos();
        public void Guardar(Producto producto)
        {
            repo.Guardar(producto);
        }

        public List<Producto> Listar()
        {
            return repo.Listar();
        }
    }
}