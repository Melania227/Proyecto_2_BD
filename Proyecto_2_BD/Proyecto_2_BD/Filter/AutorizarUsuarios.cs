using Proyecto_2_BD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_2_BD.Filter
{

    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class AutorizarUsuarios : AuthorizeAttribute
    {
        private Usuarios oUsuario;
        private Models.Proyecto_2Entities db = new Models.Proyecto_2Entities();
        private int idOperacion;
        private int idOperacion2;

        public AutorizarUsuarios(int idOperacion = 0, int idOperacion2 = -1)
        {
            this.idOperacion = idOperacion;
            this.idOperacion2 = idOperacion2;
        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {

            try
            {
                oUsuario = (Usuarios)HttpContext.Current.Session["User"];
                if (oUsuario.Tipo != this.idOperacion && oUsuario.Tipo != this.idOperacion2)
                {
                    filterContext.Result = new RedirectResult("/Contact");
                }
                else
                {
                    filterContext.Result = new RedirectResult("/About");
                }

            }
            catch
            {
                filterContext.Result = new RedirectResult("/Acceso/Login");
            }
        }
    }
}
