using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSite.Models.Entity;

namespace WebSite.Controllers
{
    public class GroupController : Controller
    {
        WebSiteEntities db = new WebSiteEntities();
        // GET: Group
        public ActionResult Index()
        {
            var groups = db.app_user_group.ToList();
            return View(groups);
        }
        public ActionResult AddGroup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddGroup(app_user_group model)
        {
             if (db.app_user_group.Any(a=>a.group_name==model.group_name))
            {
                return View();
            }
            else
            {
                app_user_group gr = new app_user_group();
                gr.group_name = model.group_name;
                gr.is_delete_table = model.is_delete_table;

                db.app_user_group.Add(gr);
                if (db.SaveChanges()>0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }
            }
        }
        public ActionResult Update(long id)
        {
            var group = db.app_user_group.FirstOrDefault(a => a.group_id == id);
            if (group != null)
            {
                return View(group);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        [HttpPost]
        public ActionResult Update(app_user_group gr)
        {
            var group = db.app_user_group.FirstOrDefault(a=>a.group_id==gr.group_id);
            if (group != null)
            {
                group.group_name = gr.group_name;
                group.is_delete_table = gr.is_delete_table;

                if (db.SaveChanges() > 0)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(group);
                }
            }
            else
            {
                return View(group);
            }        
        }
        public ActionResult Delete(long id)
        {
            var group = db.app_user_group.FirstOrDefault(a=>a.group_id== id);
            if (group!=null)
            {
                db.app_user_group.Remove(group);
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