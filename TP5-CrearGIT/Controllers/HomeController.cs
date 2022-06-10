using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TP5_CrearGIT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //CODIGO SUBIDO TP 5 CREAR CUENTA DE GIT 

            //MODIFICACION DEL CODIGO 

            int num = 0;
            string var = 0;

            return View();

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}