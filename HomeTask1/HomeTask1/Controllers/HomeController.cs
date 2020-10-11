using HomeTask1.Factory.Models;
using HomeTask1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Serialization;

namespace HomeTask1.Controllers
{
    public class HomeController : Controller
    {
        BookmakerContext db = new BookmakerContext();
        List<OneRow> rows = new List<OneRow>();
        public ActionResult Index()
        {
            OneRowFactory factory = new OneRowFactory();
            //XmlSerializer serializer = new XmlSerializer(typeof(OneRow));
            //using (StreamReader reader = new StreamReader("data.txt"))
            //{
            //    rows = serializer.Deserialize(reader) as List<OneRow>;
            //}
            //rows.Add(new OneRow(1,DateTime.Now,"First1","Second1"));
            //rows.Add(new OneRow(2,DateTime.Now,"First2","Second2"));
            //rows.Add(new OneRow(3,DateTime.Now,"First3","Second3"));
            rows = factory.CreatObject(Server.MapPath("~/App_Data/data.xml"));
            return View(rows);
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
        [HttpGet]
        public ActionResult DoBet(OneRow row)
        {
            if (row != null)
            {
                ViewBag.Title = "Ставка";
                return View(row);
            }
            else
                return HttpNotFound();
        }
        [HttpPost]
        public ActionResult DoBet(Bet bet)
        {
            if(bet.Money != 0 && bet.OwnerName != null && bet.SelectCommand != null)
            {
                bet.BetsDate = DateTime.Now;
                db.Bets.Add(bet);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}