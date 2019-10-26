using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using nba_project.Models;

namespace nba_project.Controllers
{
    public class ConferenciasController : Controller
    {
        private nba_projectContext db = new nba_projectContext();

        // GET: Conferencias
        public ActionResult Index()
        {
            return View(db.Conferencias.ToList());
        }

        // GET: Conferencias/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Conferencia conferencia = db.Conferencias.Find(id);
            if (conferencia == null)
            {
                return HttpNotFound();
            }
            return View(conferencia);
        }

        // GET: Conferencias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Conferencias/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ConferenciaID,Name")] Conferencia conferencia)
        {
            if (ModelState.IsValid)
            {
                db.Conferencias.Add(conferencia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(conferencia);
        }

        // GET: Conferencias/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Conferencia conferencia = db.Conferencias.Find(id);
            if (conferencia == null)
            {
                return HttpNotFound();
            }
            return View(conferencia);
        }

        // POST: Conferencias/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ConferenciaID,Name")] Conferencia conferencia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(conferencia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(conferencia);
        }

        // GET: Conferencias/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Conferencia conferencia = db.Conferencias.Find(id);
            if (conferencia == null)
            {
                return HttpNotFound();
            }
            return View(conferencia);
        }

        // POST: Conferencias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Conferencia conferencia = db.Conferencias.Find(id);
            db.Conferencias.Remove(conferencia);
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
