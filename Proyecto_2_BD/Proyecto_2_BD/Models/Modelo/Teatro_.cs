using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_2_BD.Models.Modelo
{
    public class Teatro_
    {
        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "Max. de caracteres sobrepasado")]
        [Required(ErrorMessage = "Tiene que ingresar un nombre válido")]
        public string Nombre { get; set; }

        [Display(Name = "Correo")]
        [MaxLength(50, ErrorMessage = "Max.de caracteres sobrepasado")]
        [Required(ErrorMessage = "Tiene que ingresar un correo electrónico")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
            ErrorMessage = "Dirección de correo electrónico inválida.")]
        public string Email_ { get; set; }

        [Display(Name = "LinkWeb")]
        [MaxLength(50, ErrorMessage = "Max. de caracteres sobrepasado")]
        [Required(ErrorMessage = "Tiene que ingresar un link válido")]
        public string LinkWeb { get; set; }

        [Display(Name = "Direccion")]
        [MaxLength(50, ErrorMessage = "Max. de caracteres sobrepasado")]
        [Required(ErrorMessage = "Tiene que ingresar una dirección válida")]
        public string Direccion { get; set; }

        [Display(Name = "TelServicioCliente")]
        [Range(10000000, 99999999, ErrorMessage = "Los numeros de telefonos son de 8 digitos")]
        [Required(ErrorMessage = "Tiene que ingresar un número de Servicio al Cliente")]
        public int TelServicioCliente { get; set; }

        [Display(Name = "TelTeatro")]
        [Range(10000000, 99999999, ErrorMessage = "Los numeros de telefonos son de 8 digitos")]
        [Required(ErrorMessage = "Tiene que ingresar un número telefónico")]
        public int TelTeatro { get; set; }

        [Display(Name = "TelBoletaria")]
        [Range(10000000, 99999999, ErrorMessage = "Los numeros de telefonos son de 8 digitos")]
        [Required(ErrorMessage = "Tiene que ingresar un número de Boletería")]
        public int TelBoletaria { get; set; }
    }
}