using DMS.DAL.DatabaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DMS.Controllers
{
    [AllowAnonymous]
    public class UsrSignUpController : Controller
    {
       

        MainEntities db = new MainEntities();
        // GET: UsrSignUp
        public ActionResult usersign()
        {
            return View();
        }
        public ActionResult SaveData(user_SignUp emp)
        {
            if(ModelState.IsValid)
            {
                db.user_SignUp.Add(emp);
                db.SaveChanges();
                return RedirectToAction("userindex", "usrlogin");
            }
            else
            {
                return View("usersign");
            }
            
        }
    }
}