using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite.Models.Entity;

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {
        WebSiteEntities db = new WebSiteEntities();
        public ActionResult Index()
        {
            ViewBag.AllUsers = db.app_users.Count();
            ViewBag.AllGroups = db.app_user_group.Count();
            ViewBag.AllAuthority = db.app_user_function.Count();
            ViewBag.SystemAdmin = db.app_users.Where(a=>a.isSystemAdmin == 1).Count();
            return View();
        }

    }
}