using DMS.DAL.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DMS.Controllers
{
    [AllowAnonymous]
    public class usrloginController : Controller
    {
        MainEntities db = new MainEntities();   
        // GET: usrlogin
        public ActionResult userindex()
        {
            return View();
        }
        public ActionResult userlgn(user_SignUp emp1)
        {
            var userdetails = db.user_SignUp.Where(x => x.username == emp1.username && x.password == emp1.password).FirstOrDefault();
            if (userdetails == null)
            {
                emp1.loginerrorMessage = "Wrong username or password";
                return View("userindex",emp1);
            }
            else
            {
                Session["username"] = userdetails.username;
                return RedirectToAction("Ghar","Home");
            }
           
        }
    }
}