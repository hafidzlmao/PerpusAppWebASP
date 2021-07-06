using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PerpusAppWeb.Models;

namespace PerpusAppWeb.Controllers
{
    public class PenulisController : Controller
    {
        private dbperpuswebEntities db = new dbperpuswebEntities();

        // GET: Penulis
        public ActionResult Index()
        {
            return View(db.penulis1.ToList());
        }

        // GET: Penulis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            penulis penulis = db.penulis1.Find(id);
            if (penulis == null)
            {
                return HttpNotFound();
            }
            return View(penulis);
        }

        // GET: Penulis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Penulis/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_penulis,nama_penulis,alamat_penulis,hp_penulis")] penulis penulis)
        {
            if (ModelState.IsValid)
            {
                db.penulis1.Add(penulis);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(penulis);
        }

        // GET: Penulis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            penulis penulis = db.penulis1.Find(id);
            if (penulis == null)
            {
                return HttpNotFound();
            }
            return View(penulis);
        }

        // POST: Penulis/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_penulis,nama_penulis,alamat_penulis,hp_penulis")] penulis penulis)
        {
            if (ModelState.IsValid)
            {
                db.Entry(penulis).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(penulis);
        }

        // GET: Penulis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            penulis penulis = db.penulis1.Find(id);
            if (penulis == null)
            {
                return HttpNotFound();
            }
            return View(penulis);
        }

        // POST: Penulis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            penulis penulis = db.penulis1.Find(id);
            db.penulis1.Remove(penulis);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
