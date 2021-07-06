using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PerpusAppWeb.Models;

namespace PerpusAppWeb.Controllers
{
    public class KembalikanbukuController : Controller
    {
        dbperpuswebEntities db = new dbperpuswebEntities();
        // GET: Kembalikanbuku
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult getMid(int mid)
        {
            var memberid = (from s in db.pinjambukus
                            where s.id_member == mid
                            select new
                            {
                                TglPinjam = s.tgl_pinjam,
                                TglKembali = s.tgl_kembali,
                                Memberid = s.id_member,
                                NamaBuku = s.id_buku,
                                LamaPinjam = SqlFunctions.DateDiff("day", s.tgl_kembali, DateTime.Now)
                            }).ToArray(); 


            return Json(memberid,JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Save(kembalikanbuku returns)
        {
            if (ModelState.IsValid)
            {
                db.kembalikanbukus.Add(returns);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(returns);
        }

    }
}