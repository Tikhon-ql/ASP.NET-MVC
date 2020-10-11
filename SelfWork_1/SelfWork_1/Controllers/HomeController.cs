using SelfWork_1.Models;
using SelfWork_1.Models.Contexts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace SelfWork_1.Controllers
{
    public class HomeController : Controller
    {
        AnimalsContext adb = new AnimalsContext();
        CommentsContext cdb = new CommentsContext();
        public ActionResult Index()
        {
            return View(adb.Animals);
        }
        [HttpGet]
        public ActionResult ShowAnimalsInfo(int? id)
        {
            Animal animal =  adb.Animals.FirstOrDefault(a => a.Id == id);
            if (animal != null)
            {
                return View(animal);
            }
            else
                return HttpNotFound();
        }
        [HttpGet]
        public ActionResult Comment()
        {
            return View(cdb.Comments);
        }
        [HttpPost]
        public ActionResult Comment(Comment comment)
        {
            comment.Date = DateTime.Now;
            cdb.Comments.Add(comment);
            cdb.SaveChanges();
            return RedirectToAction("Comment");
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