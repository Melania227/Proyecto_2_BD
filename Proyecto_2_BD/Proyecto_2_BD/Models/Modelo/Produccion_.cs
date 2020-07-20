using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_2_BD.Models.Modelo
{
    public class Produccion_
    {
        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "Max. de caracteres sobrepasado")]
        [Required(ErrorMessage = "Tiene que ingresar un nombre válido")]
        public string Nombre { get; set; }

        [Display(Name = "Descripción")]
        [MaxLength(200, ErrorMessage = "Max. de caracteres sobrepasado")]
        [Required(ErrorMessage = "Tiene que ingresar una descripción válida")]
        public string Descripcion { get; set; }


        public int Codigo { get; set; }

        public IEnumerable<Producciones> Lista;
    }

}