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
            var users = new User()
            {
                Name = "Marlowe",
                UserActions = new List<UserAction>() {new UserAction() {ActionName = "Component template"}}
            };
            var model = new Peeps();
            var userAction = new UserAction()
            {
                ActionName = "Content marlowe",
                ActionDetails = "Component Template",
                ActionTime = DateTime.Now
            };
            db.Users.Add(users);
            db.UserAction.Add(userAction);
            db.SaveChanges();
            if (db.UserAction != null)
            {
                model.UserList = db.Users.ToList();
            }
           

            model.UserList.Add(users);
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