using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Proyecto_2_BD.Models;

namespace Proyecto_2_BD.Controllers
{
    public class ProduccionesController : Controller
    {
        private Proyecto_2Entities db = new Proyecto_2Entities();

        // GET: Producciones
        public ActionResult Index()
        {
            var producciones = db.Producciones.Include(p => p.Teatros).Include(p => p.Tipos_Produccion);
            return View(producciones.ToList());
        }

        // GET: Producciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Producciones producciones = db.Producciones.Find(id);
            if (producciones == null)
            {
                return HttpNotFound();
            }
            return View(producciones);
        }

        // GET: Producciones/Create
        public ActionResult Create()
        {
            ViewBag.IdTeatro = new SelectList(db.Teatros, "IdTeatro", "Nombre");
            ViewBag.IdTipoProd = new SelectList(db.Tipos_Produccion, "IdTipoProd", "Tipo");
            return View();
        }

        // POST: Producciones/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdProduccion,Descripcion,NombrePresentacion,Estado,FechaInicio,FechaFin,IdTeatro,IdTipoProd")] Producciones producciones)
        {
            if (ModelState.IsValid)
            {
                db.Producciones.Add(producciones);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdTeatro = new SelectList(db.Teatros, "IdTeatro", "Nombre", producciones.IdTeatro);
            ViewBag.IdTipoProd = new SelectList(db.Tipos_Produccion, "IdTipoProd", "Tipo", producciones.IdTipoProd);
            return View(producciones);
        }

        // GET: Producciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Producciones producciones = db.Producciones.Find(id);
            if (producciones == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdTeatro = new SelectList(db.Teatros, "IdTeatro", "Nombre", producciones.IdTeatro);
            ViewBag.IdTipoProd = new SelectList(db.Tipos_Produccion, "IdTipoProd", "Tipo", producciones.IdTipoProd);
            return View(producciones);
        }

        // POST: Producciones/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdProduccion,Descripcion,NombrePresentacion,Estado,FechaInicio,FechaFin,IdTeatro,IdTipoProd")] Producciones producciones)
        {
            if (ModelState.IsValid)
            {
                db.Entry(producciones).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdTeatro = new SelectList(db.Teatros, "IdTeatro", "Nombre", producciones.IdTeatro);
            ViewBag.IdTipoProd = new SelectList(db.Tipos_Produccion, "IdTipoProd", "Tipo", producciones.IdTipoProd);
            return View(producciones);
        }

        // GET: Producciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Producciones producciones = db.Producciones.Find(id);
            if (producciones == null)
            {
                return HttpNotFound();
            }
            return View(producciones);
        }

        // POST: Producciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Producciones producciones = db.Producciones.Find(id);
            db.Producciones.Remove(producciones);
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
