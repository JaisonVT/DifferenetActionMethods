using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DifferenetActionMethods.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //public RedirectResult About()
        //{

        //   // ViewBag.Message = "Your application description page.";

        //    return Redirect("Contact");
        //}
        public ActionResult About()
        {

            //ViewBag.Message = "Your application description page."

            //return RedirectToAction("Index","Second",new{ fname="jai", lname="son");
            //return RedirectToRoute("SecondE");
            return JavaScript("alert(gau)");
                
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}