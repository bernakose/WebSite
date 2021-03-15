using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite.Models.Entity;

namespace WebSite.Controllers
{
    public class AuthorityController : Controller
    {
        WebSiteEntities db = new WebSiteEntities();
        // GET: authority
        public ActionResult Index()
        {
            var yetki = db.app_user_function.ToList();
            return View(yetki);
        }
        public ActionResult AddAuthority()
        {
            var listfunc = db.app_user_function.ToList();
            List<SelectListItem> sl = new List<SelectListItem>();
            foreach (var item in listfunc)
            {
                sl.Add(new SelectListItem { Text = item.func_name, Value = item.func_id.ToString() });
            }
            ViewBag.up_func_id = sl;
            return View();
        }
        [HttpPost]
        public ActionResult AddAuthority(app_user_function model)
        {
            if (model.up_func_id == 0)
            {
                var yetki = db.app_user_function.ToList();
                return View(yetki);
            }
            else if (db.app_user_function.Any(a => a.func_name == model.func_name))
            {
                var yetki = db.app_user_function.ToList();
                return View(yetki);
            }
            else
            {
                app_user_function autho = new app_user_function();

                autho.func_name = model.func_name;
                autho.tag = model.tag;
                autho.tooltip = model.tooltip;
                autho.up_func_id = model.up_func_id;

                db.app_user_function.Add(autho);
                if (db.SaveChanges() > 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    var yetki = db.app_user_function.ToList();
                    return View(yetki);
                }
            }

        }
        public ActionResult Update(long id)
        {
            var func = db.app_user_function.FirstOrDefault(a => a.func_id == id);
            if (func != null)
            {
                var listfunc = db.app_user_function.ToList();
                List<SelectListItem> sl = new List<SelectListItem>();
                foreach (var item in listfunc)
                {
                    if (item.func_id == func.up_func_id)
                    {
                        sl.Add(new SelectListItem { Text = item.func_name, Value = item.func_id.ToString(), Selected = true });
                    }
                    else
                    {
                        sl.Add(new SelectListItem { Text = item.func_name, Value = item.func_id.ToString() });
                    }
                }
                ViewBag.up_func_id = sl;

                return View(func);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public ActionResult Update(app_user_function uf)
        {
            var func = db.app_user_function.FirstOrDefault(a => a.func_id == uf.func_id);
            if (func != null)
            {
                func.func_name = uf.func_name;
                func.tag = uf.tag;
                func.tooltip = uf.tooltip;
                func.up_func_id = uf.up_func_id;

                if (db.SaveChanges() > 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(func);
                }
            }
            else
            {
                return View(func);
            }
        }
        public ActionResult Delete(long id)
        {
            var func = db.app_user_function.FirstOrDefault(a => a.func_id == id);
            if (func != null)
            {
                if (db.app_user_function.Any(a=>a.up_func_id==func.func_id))
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    db.app_user_function.Remove(func);
                    if (db.SaveChanges() > 0)
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return RedirectToAction("Index");
                    }
                }               

            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}