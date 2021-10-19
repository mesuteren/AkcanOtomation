using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicariOtomasyon.Models.Siniflar;

namespace TicariOtomasyon.Controllers
{
    public class MarkaController : Controller
    {
        // GET: Marka
        Context c = new Context();
        public ActionResult Index()
        {
            //var degerler = c.Markas.OrderByDescending(x=> x.MarkaID).ToList();
            var degerler = c.Markas.Where(x => x.Durum == true).OrderByDescending(z=> z.MarkaAd).ToList();

            return View(degerler);
        }
        [HttpGet]
        public ActionResult MarkaEkle()
        {
            return View();
        }


        [HttpPost]
        public ActionResult MarkaEkle(Marka m, HttpPostedFileBase file)
        {

            //if (file.ContentLength > 0)
            //{
            //    var folder = Server.MapPath("~/Files");
            //    var randomfilename = m.MarkaAd.ToString();
            //    var filename = Path.ChangeExtension(randomfilename, ".jpg");
            //    var path = Path.Combine(folder, filename);

            //    file.SaveAs(path);

            //    //var filename = Path.GetFileName(file.FileName);
            //    //var path = Path.Combine(Server.MapPath("~/Files"), filename);
            //    //file.SaveAs(path);
            //}

            m.Durum = true;
            c.Markas.Add(m);
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult MarkaSil(int id)
        {
            var mark = c.Markas.Find(id);
            mark.Durum = false;
            c.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult MarkaGetir(int id)
        {
            var mark = c.Markas.Find(id);
            return View("MarkaGetir", mark);
        }
        public ActionResult MarkaGuncelle(Marka m)
        {
            var mrk = c.Markas.Find(m.MarkaID);
            mrk.MarkaAd = m.MarkaAd;
            c.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult MarkaDetay(int id)
        {
            var degerler = c.Uruns.Where(x => x.MarkaID == id).ToList();
            var mrk = c.Markas.Where(x => x.MarkaID == id).Select(y => y.MarkaAd).FirstOrDefault();
            ViewBag.d = mrk;
                
            return View(degerler);
        }
        public ActionResult BrandList()
        {
            var sorgu = c.Markas.OrderBy(z => z.MarkaAd).ToList();
            return View(sorgu);
        }
    }

}