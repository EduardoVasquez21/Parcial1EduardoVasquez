using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EduardoAntonioVaquezLopez.Controllers
{
    public class CajeroController : Controller
    {
        // GET: Cajero
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Log(String monto)
        { 
            if (monto.Equals("5") && monto.Equals("10"))
            {
                return Redirect("/Cajero/Error");
            }
            return Redirect("/Cajero/SecundarioMenu");
            //else
            //{
            //    return Redirect("/Cajero/Error");
            //}
            ////return Redirect("/Cajero/Error");

        }

        public ActionResult Error()
        {

            return View();
        }

        public ActionResult SecundarioMenu()
        {

            return View();
        }

    }
}