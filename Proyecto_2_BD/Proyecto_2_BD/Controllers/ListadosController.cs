using Proyecto_2_BD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_2_BD.Controllers
{
    public class ListadosController : Controller
    {
        private Proyecto_2Entities db = new Proyecto_2Entities();
        // GET: Listados
        public ActionResult Teatros()
        {
            return View(db.Teatros.ToList());
        }

        public ActionResult Producciones()
        {
            return View(db.Producciones.ToList());
        }
    }
}