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
            int Monto= Convert.ToInt32(monto);
            //if (monto.Equals("5") /*&& monto.Equals("10")*/)
            if(Monto%5==0)
            {
                return Redirect("/Cajero/SecundarioMenu");
            }

            else
            {
                return Redirect("/Cajero/Error");
            }


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