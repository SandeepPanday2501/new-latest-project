using AutoMapper;
using DMS.DAL.DatabaseContext;
using DMS.DAL.Interfaces;
using DMS.DAL.Repositories.MainRepo;
using DMS.DAL.StaticHelper;
using DMS.Services.General.Interface;
using DMS.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DMS.Controllers
{
    //[CustomAuthentication]
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private MainEntities db;
        private SystemInfoForSession _ActiveSession;
        private IBranchesRepo _BranchesRepo;

        public HomeController(MainEntities _db, IBranchesRepo BranchesRepo)
        {
            _ActiveSession = SessionHelper.GetSession();
            db = _db;
            _BranchesRepo = BranchesRepo;
        }
        SystemInfoForSession systemSession = SessionHelper.GetSession();

        public ActionResult AccessDeniedPage()
        {
            return View();
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult details()
        {

            return View();
        }

        public ActionResult fan()
        {

            return View();
        }
        public ActionResult mixer()
        {
            return View();
        }
        public ActionResult wash()
        {
            return View();
        }
        public ActionResult tv()
        {
            return View();
        }
        public ActionResult coffee()
        {
            return View();
        }
        public ActionResult oven()
        {
            return View();
        }
        public ActionResult tost()
        {
            return View();
        }
        public ActionResult ear()
        {
            return View();
        }
        public ActionResult bud()
        {
            return View();
        }
        public ActionResult gwatch()
        {
            return View();
        }
        public ActionResult swatch()
        {
            return View();
        }
        public ActionResult mic()
        {
            return View();
        }
        public ActionResult charger()
        {
            return View();
        }
        public ActionResult router()
        {
            return View();
        }
        public ActionResult head()
        {
            return View();
        }
        public ActionResult cpu()
        {
            return View();
        }
        public ActionResult card()
        {
            return View();
        }
        public ActionResult key()
        {
            return View();
        }
        public ActionResult ssd()
        {
            return View();
        }
       
        public ActionResult mouse()
        {
            return View();
        }
        public ActionResult monitor()
        {
            return View();
        }
        public ActionResult ram()
        {
            return View();
        }
        public ActionResult casee()
        {
            return View();
        }
        public ActionResult Contact()
        {
            
            return View();
        }

        public async Task<ActionResult> Dashboard()
        {
            return RedirectToAction("Index");
        }
        public ActionResult Homeappliance()
        {
            
            return View();
        }
        public ActionResult Ghar()
        {

            return View();
        }
        public ActionResult accessories()
        {

            return View();
        }
        public ActionResult computing()
        {

            return View();
        }
        public ActionResult mobile()
        {

            return View();
        }

        public ActionResult search()
        {

            return View();
        }

        public ActionResult service()
        {

            return View();
        }
        public ActionResult contactus(contact cont)
        {
            db.contacts.Add(cont);
            db.SaveChanges();
            return RedirectToAction("Contact", "Home");
        }
    }
}