using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DMS.Controllers.Main
{
    [AllowAnonymous]
    public class AdminController : Controller
    {
        
        // GET: Admin
        public ActionResult index()
        {
            return View();
        }
        public ActionResult icon()
        {
            return View();
        }
        public ActionResult map()
        {
            return View();
        }
        public ActionResult notification()
        {
            return View();
        }
        public ActionResult table()
        {
            return View();
        }
        public ActionResult typography()
        {
            return View();
        }
        public ActionResult upgrade()
        {
            return View();
        }
        public ActionResult user()
        {
            return View();
        }
    }

}