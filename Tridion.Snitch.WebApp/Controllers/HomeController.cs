using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tridion.Snitch.Application.communication;
using Tridion.Snitch.Application.library;
using Tridion.Snitch.WebApp.Models;

namespace Tridion.Snitch.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new SnitchDb();
            var userAction = new UserAction() { ActionName = "Content marlowe" };
            db.UserAction.Add(userAction);
            db.SaveChanges();
            if (db.UserAction != null)
            {
                var users = db.UserAction.ToList();
            }
            var model = new Peeps();
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}