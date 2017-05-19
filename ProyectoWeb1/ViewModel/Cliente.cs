using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoWeb1.ViewModel
{
    public class Cliente
    {
        /*
        [HiddenInput(DisplayValue = false)]
        public int IdClienteView { get; set; }
       */ [Required]
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