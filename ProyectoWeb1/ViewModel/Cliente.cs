using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoWeb1.ViewModel
{
    public class Cliente
    {
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string Nombre { get; set; }
        //public Cliente(string Apellido, string Nombre)
        //{
        //    this.Apellido = Apellido;
        //    this.Nombre = Nombre;
        //}
        public Cliente()
        {

        }
    }
}