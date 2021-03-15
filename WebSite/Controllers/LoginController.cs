using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite.Models;
using WebSite.Models.Entity;

namespace WebSite.Controllers
{
    public class LoginController : Controller
    {
        WebSiteEntities db = new WebSiteEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel model)
        {
            if (model.Username != null && model.Password != null)
            {
                if (db.app_users.Any(a=>a.username == model.Username && a.password == model.Password))
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return View();
                }

            }
            else
            {
                return View();
            }

        }
        public ActionResult LogOut()
        {
            return RedirectToAction("Index");
        }
    }
}