using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Proyecto_2_BD.Filter;
using Proyecto_2_BD.Models;
using Proyecto_2_BD.Models.Modelo;

namespace Proyecto_2_BD.Controllers
{
    public class AddController : Controller
    {
        private Proyecto_2Entities db = new Proyecto_2Entities();

        // GET: Humanos/CreateAdm
        public ActionResult Create()
        {
            Usuarios oUsuario = (Usuarios)System.Web.HttpContext.Current.Session["User"];
            if (oUsuario.Tipo == 1)
            {
                ViewBag.Tipos = new SelectList(new[] {
                new SelectListItem { Value = "1", Text = "Administrador de Sistemas" },
                new SelectListItem { Value = "2", Text = "Administrador de Teatros" } },
                "Value", "Text");
            }
            else
            {
                ViewBag.Tipos = new SelectList(new[] {
                new SelectListItem { Value = "1", Text = "Agente Autorizado" } },
                "Value", "Text");
            }
            ViewBag.Usuario = oUsuario;
            ViewBag.sexo = new SelectList(new[] {
                new SelectListItem { Value = "1", Text = "Hombre" },
                new SelectListItem { Value = "2", Text = "Mujer" },
                new SelectListItem { Value = "3", Text = "Prefiero no especificar" } }, "Value", "Text");
            ViewBag.teatro = new SelectList(db.Teatros, "IdTeatro", "Nombre");
            return View();
        }

        // POST: Humanos/CreateAdm
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Humano_Usuario humanos)
        {
            Usuarios oUsuario = (Usuarios)System.Web.HttpContext.Current.Session["User"];
            ObjectParameter result1 = new ObjectParameter("ReturnMessage", typeof(int));
            string pass_ = PassController.ComputeHash(humanos.Password_, null);

            db.spAddUnHumano(humanos.Cedula, humanos.Nombre, humanos.Apellidos, humanos.Fec_Nacimiento, humanos.Direccion, humanos.Sexo, humanos.NumCasa, humanos.NumTelefono, humanos.NumOtro, humanos.Correo);
            db.spAddUnUsuario(oUsuario.IdUsuario, humanos.Cedula, humanos.Usuario, pass_, humanos.Tipo, humanos.Teatro, result1);

            ViewBag.Msg = true;
            return View();
        }


        // GET: Humanos/CreateAdm
        public ActionResult Teatro()
        {
            return View();
        }

        // POST: Humanos/CreateAdm
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Teatro(Teatro_ teatro)
        {
            Usuarios oUsuario = (Usuarios)System.Web.HttpContext.Current.Session["User"];
            ObjectParameter result1 = new ObjectParameter("ReturnMessage", typeof(int));
            db.spAddUnTeatro(oUsuario.IdUsuario, teatro.Nombre, teatro.Direccion, teatro.TelTeatro, teatro.TelBoletaria, teatro.TelServicioCliente, result1);
            return View();
        }

        public ActionResult Bloques()
        { 
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Bloques(Distribucion[] Dist)
        {
            return View();
        }

        public ActionResult Producciones()
        {
            ViewBag.Lista = db.Producciones.ToList();
            ViewBag.Codigo = new SelectList(db.Tipos_Produccion.OrderBy(o => o.IdTipoProd), "IdTipoProd", "Tipo");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Producciones(Produccion_ produccion)
        {
            return View();
        }

        public ActionResult Presentaciones()
        {
           // Usuarios oUsuario = (Usuarios)System.Web.HttpContext.Current.Session["User"];
           // ViewBag.Prod = new SelectList(db.Producciones.Where(x => x.IdTeatro == oUsuario.IdTeatro_usuarios), "IdProduccion", "NombrePresentacion");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
         public ActionResult Presentaciones(Presentacion_ presentacion)
        {
            return View();
        }



        // GET: Humanos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Humanos humanos = db.Humanos.Find(id);
            if (humanos == null)
            {
                return HttpNotFound();
            }
            return View(humanos);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        // POST: Humanos/Delete/5
        public ActionResult DeleteConfirmed(int id)
        {
            Humanos humanos = db.Humanos.Find(id);
            db.Humanos.Remove(humanos);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
