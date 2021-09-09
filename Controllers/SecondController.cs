using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DifferenetActionMethods.Controllers
{
    public class SecondController : Controller
    {
        // GET: Second
        public string Index(string fname, string lname)
        {
            return $"hello {fname} {lname}";
        }
    }
}