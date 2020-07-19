﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Proyecto_2Entities : DbContext
    {
        public Proyecto_2Entities()
            : base("name=Proyecto_2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<Bloques> Bloques { get; set; }
        public virtual DbSet<Boletos> Boletos { get; set; }
        public virtual DbSet<Filas> Filas { get; set; }
        public virtual DbSet<Humanos> Humanos { get; set; }
        public virtual DbSet<Precio_X_Bloque> Precio_X_Bloque { get; set; }
        public virtual DbSet<Presentaciones> Presentaciones { get; set; }
        public virtual DbSet<Producciones> Producciones { get; set; }
        public virtual DbSet<Teatros> Teatros { get; set; }
        public virtual DbSet<Tipos_Produccion> Tipos_Produccion { get; set; }
        public virtual DbSet<Transacciones> Transacciones { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
    
        public virtual int spAddPrecioBloquePorProduccion(Nullable<int> idBloque, Nullable<int> idProduccion, Nullable<decimal> precio, ObjectParameter returnMessage)
        {
            var idBloqueParameter = idBloque.HasValue ?
                new ObjectParameter("IdBloque", idBloque) :
                new ObjectParameter("IdBloque", typeof(int));
    
            var idProduccionParameter = idProduccion.HasValue ?
                new ObjectParameter("IdProduccion", idProduccion) :
                new ObjectParameter("IdProduccion", typeof(int));
    
            var precioParameter = precio.HasValue ?
                new ObjectParameter("Precio", precio) :
                new ObjectParameter("Precio", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddPrecioBloquePorProduccion", idBloqueParameter, idProduccionParameter, precioParameter, returnMessage);
        }
    
        public virtual int spAddUnaProduccion(string descripcion, string nombrePresentacion, Nullable<int> idTeatro, Nullable<int> idTipoProd, Nullable<int> idCreador, ObjectParameter returnMessage)
        {
            var descripcionParameter = descripcion != null ?
                new ObjectParameter("Descripcion", descripcion) :
                new ObjectParameter("Descripcion", typeof(string));
    
            var nombrePresentacionParameter = nombrePresentacion != null ?
                new ObjectParameter("NombrePresentacion", nombrePresentacion) :
                new ObjectParameter("NombrePresentacion", typeof(string));
    
            var idTeatroParameter = idTeatro.HasValue ?
                new ObjectParameter("IdTeatro", idTeatro) :
                new ObjectParameter("IdTeatro", typeof(int));
    
            var idTipoProdParameter = idTipoProd.HasValue ?
                new ObjectParameter("IdTipoProd", idTipoProd) :
                new ObjectParameter("IdTipoProd", typeof(int));
    
            var idCreadorParameter = idCreador.HasValue ?
                new ObjectParameter("IdCreador", idCreador) :
                new ObjectParameter("IdCreador", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddUnaProduccion", descripcionParameter, nombrePresentacionParameter, idTeatroParameter, idTipoProdParameter, idCreadorParameter, returnMessage);
        }
    
        public virtual int spAddUnHumano(Nullable<int> cedula, string nombre, string apellidos, Nullable<System.DateTime> fec_Nacimiento, string direccion, string sexo, Nullable<int> numcasa, Nullable<int> numTelefono, Nullable<int> numOtro, string correo)
        {
            var cedulaParameter = cedula.HasValue ?
                new ObjectParameter("Cedula", cedula) :
                new ObjectParameter("Cedula", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apellidosParameter = apellidos != null ?
                new ObjectParameter("Apellidos", apellidos) :
                new ObjectParameter("Apellidos", typeof(string));
    
            var fec_NacimientoParameter = fec_Nacimiento.HasValue ?
                new ObjectParameter("Fec_Nacimiento", fec_Nacimiento) :
                new ObjectParameter("Fec_Nacimiento", typeof(System.DateTime));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var sexoParameter = sexo != null ?
                new ObjectParameter("Sexo", sexo) :
                new ObjectParameter("Sexo", typeof(string));
    
            var numcasaParameter = numcasa.HasValue ?
                new ObjectParameter("Numcasa", numcasa) :
                new ObjectParameter("Numcasa", typeof(int));
    
            var numTelefonoParameter = numTelefono.HasValue ?
                new ObjectParameter("NumTelefono", numTelefono) :
                new ObjectParameter("NumTelefono", typeof(int));
    
            var numOtroParameter = numOtro.HasValue ?
                new ObjectParameter("NumOtro", numOtro) :
                new ObjectParameter("NumOtro", typeof(int));
    
            var correoParameter = correo != null ?
                new ObjectParameter("Correo", correo) :
                new ObjectParameter("Correo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddUnHumano", cedulaParameter, nombreParameter, apellidosParameter, fec_NacimientoParameter, direccionParameter, sexoParameter, numcasaParameter, numTelefonoParameter, numOtroParameter, correoParameter);
        }
    
        public virtual int spAddUnPresentacion(Nullable<int> idProduccion, Nullable<System.DateTime> fecha, Nullable<System.TimeSpan> hora, ObjectParameter returnMessage)
        {
            var idProduccionParameter = idProduccion.HasValue ?
                new ObjectParameter("IdProduccion", idProduccion) :
                new ObjectParameter("IdProduccion", typeof(int));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("Fecha", fecha) :
                new ObjectParameter("Fecha", typeof(System.DateTime));
    
            var horaParameter = hora.HasValue ?
                new ObjectParameter("Hora", hora) :
                new ObjectParameter("Hora", typeof(System.TimeSpan));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddUnPresentacion", idProduccionParameter, fechaParameter, horaParameter, returnMessage);
        }
    
        public virtual int spAddUnTeatro(Nullable<int> idCreador, string nombre, string direccion, Nullable<int> telTeatro, Nullable<int> telBoleteria, Nullable<int> telServicioCliente, ObjectParameter returnMessage)
        {
            var idCreadorParameter = idCreador.HasValue ?
                new ObjectParameter("IdCreador", idCreador) :
                new ObjectParameter("IdCreador", typeof(int));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var direccionParameter = direccion != null ?
                new ObjectParameter("Direccion", direccion) :
                new ObjectParameter("Direccion", typeof(string));
    
            var telTeatroParameter = telTeatro.HasValue ?
                new ObjectParameter("TelTeatro", telTeatro) :
                new ObjectParameter("TelTeatro", typeof(int));
    
            var telBoleteriaParameter = telBoleteria.HasValue ?
                new ObjectParameter("TelBoleteria", telBoleteria) :
                new ObjectParameter("TelBoleteria", typeof(int));
    
            var telServicioClienteParameter = telServicioCliente.HasValue ?
                new ObjectParameter("TelServicioCliente", telServicioCliente) :
                new ObjectParameter("TelServicioCliente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddUnTeatro", idCreadorParameter, nombreParameter, direccionParameter, telTeatroParameter, telBoleteriaParameter, telServicioClienteParameter, returnMessage);
        }
    
        public virtual int spAddUnTipoProduccion(string tipo)
        {
            var tipoParameter = tipo != null ?
                new ObjectParameter("Tipo", tipo) :
                new ObjectParameter("Tipo", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddUnTipoProduccion", tipoParameter);
        }
    
        public virtual int spAddUnUsuario(Nullable<int> idCreador, Nullable<int> idUsuarioHumano, string usuario, string password, Nullable<int> tipo, Nullable<int> idTeatroHumano, ObjectParameter returnMessage)
        {
            var idCreadorParameter = idCreador.HasValue ?
                new ObjectParameter("IdCreador", idCreador) :
                new ObjectParameter("IdCreador", typeof(int));
    
            var idUsuarioHumanoParameter = idUsuarioHumano.HasValue ?
                new ObjectParameter("IdUsuarioHumano", idUsuarioHumano) :
                new ObjectParameter("IdUsuarioHumano", typeof(int));
    
            var usuarioParameter = usuario != null ?
                new ObjectParameter("Usuario", usuario) :
                new ObjectParameter("Usuario", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            var tipoParameter = tipo.HasValue ?
                new ObjectParameter("Tipo", tipo) :
                new ObjectParameter("Tipo", typeof(int));
    
            var idTeatroHumanoParameter = idTeatroHumano.HasValue ?
                new ObjectParameter("IdTeatroHumano", idTeatroHumano) :
                new ObjectParameter("IdTeatroHumano", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spAddUnUsuario", idCreadorParameter, idUsuarioHumanoParameter, usuarioParameter, passwordParameter, tipoParameter, idTeatroHumanoParameter, returnMessage);
        }
    
        public virtual ObjectResult<Nullable<int>> spAsientosNoDisponiblesEnBloque(Nullable<int> idBloque, Nullable<int> idPresentacion)
        {
            var idBloqueParameter = idBloque.HasValue ?
                new ObjectParameter("IdBloque", idBloque) :
                new ObjectParameter("IdBloque", typeof(int));
    
            var idPresentacionParameter = idPresentacion.HasValue ?
                new ObjectParameter("IdPresentacion", idPresentacion) :
                new ObjectParameter("IdPresentacion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("spAsientosNoDisponiblesEnBloque", idBloqueParameter, idPresentacionParameter);
        }
    
        public virtual ObjectResult<string> spAuthenticationUser(string user, ObjectParameter password)
        {
            var userParameter = user != null ?
                new ObjectParameter("User", user) :
                new ObjectParameter("User", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("spAuthenticationUser", userParameter, password);
        }
    
        public virtual ObjectResult<Nullable<int>> spAuthenticationUserName(string user)
        {
            var userParameter = user != null ?
                new ObjectParameter("User", user) :
                new ObjectParameter("User", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("spAuthenticationUserName", userParameter);
        }
    
        public virtual int spDefineBloque(Nullable<int> idTeatro, string nombreBloque, ObjectParameter returnMessage)
        {
            var idTeatroParameter = idTeatro.HasValue ?
                new ObjectParameter("IdTeatro", idTeatro) :
                new ObjectParameter("IdTeatro", typeof(int));
    
            var nombreBloqueParameter = nombreBloque != null ?
                new ObjectParameter("NombreBloque", nombreBloque) :
                new ObjectParameter("NombreBloque", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDefineBloque", idTeatroParameter, nombreBloqueParameter, returnMessage);
        }
    
        public virtual int spDefineFilas(Nullable<int> idBloque, string letraFila, Nullable<int> cantAsientos, ObjectParameter returnMessage)
        {
            var idBloqueParameter = idBloque.HasValue ?
                new ObjectParameter("IdBloque", idBloque) :
                new ObjectParameter("IdBloque", typeof(int));
    
            var letraFilaParameter = letraFila != null ?
                new ObjectParameter("LetraFila", letraFila) :
                new ObjectParameter("LetraFila", typeof(string));
    
            var cantAsientosParameter = cantAsientos.HasValue ?
                new ObjectParameter("CantAsientos", cantAsientos) :
                new ObjectParameter("CantAsientos", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spDefineFilas", idBloqueParameter, letraFilaParameter, cantAsientosParameter, returnMessage);
        }
    
        public virtual ObjectResult<spFindBloquesForPresentacion_Result> spFindBloquesForPresentacion(Nullable<int> idPresentacion)
        {
            var idPresentacionParameter = idPresentacion.HasValue ?
                new ObjectParameter("IdPresentacion", idPresentacion) :
                new ObjectParameter("IdPresentacion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spFindBloquesForPresentacion_Result>("spFindBloquesForPresentacion", idPresentacionParameter);
        }
    
        public virtual ObjectResult<spFindFilasForBloque_Result> spFindFilasForBloque(Nullable<int> idBloque)
        {
            var idBloqueParameter = idBloque.HasValue ?
                new ObjectParameter("IdBloque", idBloque) :
                new ObjectParameter("IdBloque", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spFindFilasForBloque_Result>("spFindFilasForBloque", idBloqueParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> spFindPrecioXBloque(Nullable<int> idBloque)
        {
            var idBloqueParameter = idBloque.HasValue ?
                new ObjectParameter("IdBloque", idBloque) :
                new ObjectParameter("IdBloque", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("spFindPrecioXBloque", idBloqueParameter);
        }
    
        public virtual ObjectResult<spGetPresentacionesOfProduccionBetweenDates_Result> spGetPresentacionesOfProduccionBetweenDates(Nullable<System.DateTime> fechaInicio, Nullable<System.DateTime> fechaFinal, Nullable<int> idProduccion)
        {
            var fechaInicioParameter = fechaInicio.HasValue ?
                new ObjectParameter("FechaInicio", fechaInicio) :
                new ObjectParameter("FechaInicio", typeof(System.DateTime));
    
            var fechaFinalParameter = fechaFinal.HasValue ?
                new ObjectParameter("FechaFinal", fechaFinal) :
                new ObjectParameter("FechaFinal", typeof(System.DateTime));
    
            var idProduccionParameter = idProduccion.HasValue ?
                new ObjectParameter("IdProduccion", idProduccion) :
                new ObjectParameter("IdProduccion", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetPresentacionesOfProduccionBetweenDates_Result>("spGetPresentacionesOfProduccionBetweenDates", fechaInicioParameter, fechaFinalParameter, idProduccionParameter);
        }
    
        public virtual ObjectResult<spGetProduccionesBetweenDates_Result> spGetProduccionesBetweenDates(Nullable<System.DateTime> fechaInicio, Nullable<System.DateTime> fechaFinal)
        {
            var fechaInicioParameter = fechaInicio.HasValue ?
                new ObjectParameter("FechaInicio", fechaInicio) :
                new ObjectParameter("FechaInicio", typeof(System.DateTime));
    
            var fechaFinalParameter = fechaFinal.HasValue ?
                new ObjectParameter("FechaFinal", fechaFinal) :
                new ObjectParameter("FechaFinal", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetProduccionesBetweenDates_Result>("spGetProduccionesBetweenDates", fechaInicioParameter, fechaFinalParameter);
        }
    
        public virtual ObjectResult<spGetTypeOfUser_Result> spGetTypeOfUser(string user, string password)
        {
            var userParameter = user != null ?
                new ObjectParameter("User", user) :
                new ObjectParameter("User", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetTypeOfUser_Result>("spGetTypeOfUser", userParameter, passwordParameter);
        }
    
        public virtual int spRevisarFecha(Nullable<int> idProduccionR, Nullable<System.DateTime> fechaR)
        {
            var idProduccionRParameter = idProduccionR.HasValue ?
                new ObjectParameter("IdProduccionR", idProduccionR) :
                new ObjectParameter("IdProduccionR", typeof(int));
    
            var fechaRParameter = fechaR.HasValue ?
                new ObjectParameter("FechaR", fechaR) :
                new ObjectParameter("FechaR", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spRevisarFecha", idProduccionRParameter, fechaRParameter);
        }
    
        public virtual int spUpdateEstado(Nullable<int> idUsuario, Nullable<int> idProduccion, string estado)
        {
            var idUsuarioParameter = idUsuario.HasValue ?
                new ObjectParameter("IdUsuario", idUsuario) :
                new ObjectParameter("IdUsuario", typeof(int));
    
            var idProduccionParameter = idProduccion.HasValue ?
                new ObjectParameter("IdProduccion", idProduccion) :
                new ObjectParameter("IdProduccion", typeof(int));
    
            var estadoParameter = estado != null ?
                new ObjectParameter("Estado", estado) :
                new ObjectParameter("Estado", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateEstado", idUsuarioParameter, idProduccionParameter, estadoParameter);
        }
    }
}
