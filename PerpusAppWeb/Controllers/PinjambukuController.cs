using PerpusAppWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PerpusAppWeb.Controllers
{
    public class PinjambukuController : Controller
    {
        dbperpuswebEntities db= new dbperpuswebEntities();

        // GET: Pinjambuku
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult getMid(int mid)
        {
            var memberid = (from s in db.members where s.id_member == mid select s.nama_member).ToList();
            return Json(memberid, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult save(pinjambuku pinjam)
        {
            if (ModelState.IsValid)
            {
                db.pinjambukus.Add(pinjam);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pinjam);
        }

        [HttpGet]
        public ActionResult getBuku()
        {
            var buku = db.bukus.Select(p => new
            {
                id=p.id_buku,
                nama_buku = p.nama_buku
            }).ToList();
            return Json(buku, JsonRequestBehavior.AllowGet);
        }
    }
}
