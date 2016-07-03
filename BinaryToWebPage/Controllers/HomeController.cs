using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BinaryToWebPage.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomeModel model = new HomeModel();

            //model.Slika=Convert.ToBase64String(System.IO.File.ReadAllBytes("D:/brisati.jpg"));

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

        public string DonesiSliku()
        {
            return Convert.ToBase64String(System.IO.File.ReadAllBytes("D:/brisati.jpg")); ;
        }
    }
}