using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_2_BD.Models.Modelo
{
    public class Humano_Usuario
    {

        [Display(Name = "Nombre ")]
        [MaxLength(25, ErrorMessage = "Max. de caracteres sobrepasado")]
        [Required(ErrorMessage = "Tiene que ingresar un nombre válido")]
        public string Nombre { get; set; }

        [Display(Name = "Apellidos")]
        [MaxLength(25, ErrorMessage = "Max. de caracteres sobrepasado")]
        [Required(ErrorMessage = "Tiene que ingresar un nombre válido")]
        public string Apellidos { get; set; }

        [Display(Name = "Cedula")]
        [Range(100000000, 999999999, ErrorMessage = "Numero fuera de rango")]
        [Required(ErrorMessage = "Tiene que ingresar un número de cédula")]
        [Remote("doesCedulaExist", "Acceso", HttpMethod = "POST", ErrorMessage = "Este usuario ya ha sido registrado")]
        public int Cedula { get; set; }

        [Display(Name = "Correo")]
        [MaxLength(50, ErrorMessage = "Max.de caracteres sobrepasado")]
        [Required(ErrorMessage = "Tiene que ingresar un correo electrónico")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*",
            ErrorMessage = "Dirección de correo electrónico inválida.")]
        [DataType(DataType.EmailAddress)]
        public string Correo { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Fecha de Nacimiento")]
        [Required(ErrorMessage = "Tiene que ingresar una fecha válida")]
        public DateTime? Fec_Nacimiento { get; set; }

        [Display(Name = "Dirección")]
        [MaxLength(50, ErrorMessage = "Max. de caracteres sobrepasado")]
        [Required(ErrorMessage = "Tiene que ingresar una dirección válido")]
        public string Direccion { get; set; }

        [Display(Name = "Sexo")]
        public string Sexo { get; set; }

        [Display(Name = "Telefono")]
        [Range(20000000, 99999999, ErrorMessage = "Los numeros de telefonos son de 8 digitos")]
        [Required(ErrorMessage = "Tiene que ingresar un número telefónico")]
        public int NumCasa { get; set; }

        [Display(Name = "Celular")]
        [Range(10000000, 99999999, ErrorMessage = "Los numeros de telefonos son de 8 digitos")]
        [Required(ErrorMessage = "Tiene que ingresar un número telefónico")]
        public int NumTelefono { get; set; }

        [Display(Name = "Otro")]
        [Range(10000000, 99999999, ErrorMessage = "Los numeros de telefonos son de 8 digitos")]
        [Required(ErrorMessage = "Tiene que ingresar un número telefónico")]
        public int NumOtro { get; set; }

        [Display(Name = "Usuario")]
        [MaxLength(15, ErrorMessage = "Max. de caracteres sobrepasado")]
        [Remote("doesUserNameExist", "Acceso", HttpMethod = "POST", ErrorMessage = "El nombre de usuario no está disponible")]
        public string Usuario { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        [StringLength(15, ErrorMessage = "Longitud entre 6 y 15 caracteres.",
                      MinimumLength = 6)]
        [Required(ErrorMessage = "Tiene que ingresar una contrasena válido")]
        public string Password_ { get; set; }

        [Display(Name = "IdTeatro")]
        public int Teatro { get; set; }

        [Display(Name = "IdTipo")]
        public int Tipo { get; set; }

        [Display(Name = "User")]
        public Usuarios User { get; set; }

    }
}
