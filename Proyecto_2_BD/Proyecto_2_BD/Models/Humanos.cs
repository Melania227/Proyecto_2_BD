//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_2_BD.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Humanos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Humanos()
        {
            this.Usuarios = new HashSet<Usuarios>();
        }
    
        public int Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Correo { get; set; }
        public System.DateTime Fec_Nacimiento { get; set; }
        public string Direccion { get; set; }
        public string Sexo { get; set; }
        public Nullable<int> NumCasa { get; set; }
        public int NumTelefono { get; set; }
        public Nullable<int> NumOtro { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}