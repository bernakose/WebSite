using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite.Models.Entity;

namespace WebSite.Controllers
{
    public class UserController : Controller
    {
        WebSiteEntities db = new WebSiteEntities();

        // GET: User
        public ActionResult Index()
        {
            var users = db.app_users.ToList();

            return View(users);
        }
        public ActionResult AddUser()
        {
            var listfunc = db.app_user_group.ToList();
            List<SelectListItem> sl = new List<SelectListItem>();
            foreach (var item in listfunc)
            {
                sl.Add(new SelectListItem { Text = item.group_name, Value = item.group_id.ToString() });
            }
            ViewBag.group_id = sl;
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(app_users model)
        {
            if (db.app_users.Any(a => a.username == model.username))
            {
                return View();
            }
            else
            {
                app_users us = new app_users();
                us.username = model.username;
                us.usersurname = model.usersurname;
                us.userphone = model.userphone;
                us.usermail = model.usermail;
                us.avatarImage = "";
                us.groupId = 1;
                us.isSystemAdmin = 0;
                us.usertc = model.usertc;
                us.password = model.password;


                db.app_users.Add(us);
                if (db.SaveChanges() > 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }

            }

        }
        public ActionResult Guncelle(long id)
        {
            var user = db.app_users.FirstOrDefault(a => a.Id == id);
            if (user != null)
            {
                return View(user);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public ActionResult Guncelle(app_users u)
        {
            var user = db.app_users.FirstOrDefault(a => a.Id == u.Id);
            if (user != null)
            {

                user.password = u.password;
                user.usermail = u.usermail;
                user.username = u.username;
                user.userphone = u.userphone;
                user.usersurname = u.usersurname;
                user.usertc = u.usertc;

                if( db.SaveChanges()>0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(user);
                }
            }
            else
            {
                return View(user);
            }
        }

        public ActionResult Delete(long id)
        {
            var user = db.app_users.FirstOrDefault(a=>a.Id == id);
            if (user!=null)
            {
                db.app_users.Remove(user);
                if (db.SaveChanges()>0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Index");
                }
                
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}