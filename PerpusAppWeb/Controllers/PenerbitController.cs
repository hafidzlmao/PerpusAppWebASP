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
    public class PenerbitController : Controller
    {
        private dbperpuswebEntities db = new dbperpuswebEntities();

        // GET: Penerbit
        public ActionResult Index()
        {
            return View(db.penerbits.ToList());
        }

        // GET: Penerbit/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            penerbit penerbit = db.penerbits.Find(id);
            if (penerbit == null)
            {
                return HttpNotFound();
            }
            return View(penerbit);
        }

        // GET: Penerbit/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Penerbit/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_penerbit,nama_penerbit,alamat_penerbit,hp_penerbit")] penerbit penerbit)
        {
            if (ModelState.IsValid)
            {
                db.penerbits.Add(penerbit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(penerbit);
        }

        // GET: Penerbit/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            penerbit penerbit = db.penerbits.Find(id);
            if (penerbit == null)
            {
                return HttpNotFound();
            }
            return View(penerbit);
        }

        // POST: Penerbit/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_penerbit,nama_penerbit,alamat_penerbit,hp_penerbit")] penerbit penerbit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(penerbit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(penerbit);
        }

        // GET: Penerbit/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            penerbit penerbit = db.penerbits.Find(id);
            if (penerbit == null)
            {
                return HttpNotFound();
            }
            return View(penerbit);
        }

        // POST: Penerbit/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            penerbit penerbit = db.penerbits.Find(id);
            db.penerbits.Remove(penerbit);
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
