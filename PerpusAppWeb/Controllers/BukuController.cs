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
    public class BukuController : Controller
    {
        private dbperpuswebEntities db = new dbperpuswebEntities();

        // GET: Buku
        public ActionResult Index()
        {
            var bukus = db.bukus.Include(b => b.kategori).Include(b => b.penerbit).Include(b => b.penuli);
            return View(bukus.ToList());
        }

        // GET: Buku/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            buku buku = db.bukus.Find(id);
            if (buku == null)
            {
                return HttpNotFound();
            }
            return View(buku);
        }

        // GET: Buku/Create
        public ActionResult Create()
        {
            ViewBag.id_kategori = new SelectList(db.kategoris, "id_kategori", "nama_kategori");
            ViewBag.id_penerbit = new SelectList(db.penerbits, "id_penerbit", "nama_penerbit");
            ViewBag.id_penulis = new SelectList(db.penulis1, "id_penulis", "nama_penulis");
            return View();
        }

        // POST: Buku/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_buku,nama_buku,id_kategori,id_penulis,id_penerbit,halaman")] buku buku)
        {
            if (ModelState.IsValid)
            {
                db.bukus.Add(buku);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.id_kategori = new SelectList(db.kategoris, "id_kategori", "nama_kategori", buku.id_kategori);
            ViewBag.id_penerbit = new SelectList(db.penerbits, "id_penerbit", "nama_penerbit", buku.id_penerbit);
            ViewBag.id_penulis = new SelectList(db.penulis1, "id_penulis", "nama_penulis", buku.id_penulis);
            return View(buku);
        }

        // GET: Buku/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            buku buku = db.bukus.Find(id);
            if (buku == null)
            {
                return HttpNotFound();
            }
            ViewBag.id_kategori = new SelectList(db.kategoris, "id_kategori", "nama_kategori", buku.id_kategori);
            ViewBag.id_penerbit = new SelectList(db.penerbits, "id_penerbit", "nama_penerbit", buku.id_penerbit);
            ViewBag.id_penulis = new SelectList(db.penulis1, "id_penulis", "nama_penulis", buku.id_penulis);
            return View(buku);
        }

        // POST: Buku/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_buku,nama_buku,id_kategori,id_penulis,id_penerbit,halaman")] buku buku)
        {
            if (ModelState.IsValid)
            {
                db.Entry(buku).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.id_kategori = new SelectList(db.kategoris, "id_kategori", "nama_kategori", buku.id_kategori);
            ViewBag.id_penerbit = new SelectList(db.penerbits, "id_penerbit", "nama_penerbit", buku.id_penerbit);
            ViewBag.id_penulis = new SelectList(db.penulis1, "id_penulis", "nama_penulis", buku.id_penulis);
            return View(buku);
        }

        // GET: Buku/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            buku buku = db.bukus.Find(id);
            if (buku == null)
            {
                return HttpNotFound();
            }
            return View(buku);
        }

        // POST: Buku/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            buku buku = db.bukus.Find(id);
            db.bukus.Remove(buku);
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
