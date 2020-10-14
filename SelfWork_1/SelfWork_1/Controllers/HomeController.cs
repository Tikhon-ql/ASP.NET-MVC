using SelfWork_1.Models;
using SelfWork_1.Models.Animals;
using SelfWork_1.Models.Animals.Context;
using SelfWork_1.Models.Comments;
using SelfWork_1.Models.Comments.Context;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.IO;

namespace SelfWork_1.Controllers
{
    public class HomeController : Controller
    {
        AnimalsContext adb = new AnimalsContext();
        CommentsContext cdb = new CommentsContext();
        public ActionResult Index()
        {
            //DirectoryInfo dir = new DirectoryInfo(Server.MapPath("~/Content/images"));
            //foreach (FileInfo item in dir.GetFiles())
            //{
            //    using (MemoryStream ms = new MemoryStream())
            //    {
            //        System.Drawing.Image image = System.Drawing.Image.FromFile(item.FullName);
            //        image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            //        Animal animal = adb.Animals.FirstOrDefault(a=>(a.Name).ToLower() + ".jpg" == item.Name);
            //        animal.AnimalImage = ms.ToArray();
            //    }
            //    adb.SaveChanges();
            //}
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