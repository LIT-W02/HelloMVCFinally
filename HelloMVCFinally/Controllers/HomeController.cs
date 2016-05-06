using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMVCFinally.Controllers
{
    public class HomeController : Controller
    {
        public void Index()
        {
            Response.Write("<h1>Home#Index</h1>");
        }

        public ActionResult CurrentTime()
        {
            return View(DateTime.Now);
        }

    }
}
