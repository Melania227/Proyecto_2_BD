using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_2_BD.Models.Modelo
{
    public class Distribucion
    {
        [Required]
        public string name { get; set; }

        [Required]
        public int filas { get; set; }

        [Required]
        public int sillas { get; set; }


    }
    
}