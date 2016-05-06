using HelloMVCFinally.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMVCFinally.Controllers
{
    public class PeopleController : Controller
    {
        public ActionResult Index()
        {
            PeopleManager manager = new PeopleManager(Properties.Settings.Default.ConStr);
            return View(manager.GetAll());
        }
    }
}
