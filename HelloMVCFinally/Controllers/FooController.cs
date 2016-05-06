using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMVCFinally.Controllers
{
    public class FooController : Controller
    {
        public void Index()
        {
            Response.Write("<h1>Hello Web!!</h1>");
        }

        public void Somethingelse()
        {
            Response.Write("<h1>Something else....</h1>");
        }

        public ActionResult Awesome()
        {
            return View();
        }
    }
}

//home/index
//home/foo
//about/index
