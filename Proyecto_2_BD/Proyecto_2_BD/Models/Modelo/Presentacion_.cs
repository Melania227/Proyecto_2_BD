using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proyecto_2_BD.Models.Modelo
{
	public class Presentacion_
	{
		[Display(Name = "Fecha")]
		public DateTime? Fecha { get; set; }

		[Display(Name = "Hora"), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm:ss tt}")]
		public string Hora { get; set; }



		[Display(Name = "IdProduccion")]
		public int IdProduccion { get; set; }
	}
}