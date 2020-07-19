using Proyecto_2_BD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_2_BD.Controllers
{
    public class AccesoController : Controller
    {
        private Proyecto_2Entities db = new Proyecto_2Entities();

        // GET: Acceso
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string uname, string psw)
        {
            try
            {
                
                Usuarios usuario = db.Usuarios.Where(x => x.Usuario == uname).FirstOrDefault();
                bool result = PassController.ConfirmPassword(psw, usuario.Password);
                if (result)
                {
                    ViewBag.msg = true;
                    Session["User"] = usuario;
                    return View();
                }
                else {
                    ViewBag.msg = false;
                    return View();
                }
            }
            catch
            {
                ViewBag.msg = false;
                return View();
            }
        }

        [HttpPost]
        public JsonResult doesUserNameExist(string Usuario)
        {
            bool res = db.Usuarios.Any(x => x.Usuario == Usuario);
            if(res)
                return Json(false, JsonRequestBehavior.AllowGet);
            else
                return Json(true, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult doesCedulaExist( int cedula)
        {
            return Json(!db.Usuarios.Any(x => x.IdUsuarioHumano == cedula), JsonRequestBehavior.AllowGet);

        }
    }

}