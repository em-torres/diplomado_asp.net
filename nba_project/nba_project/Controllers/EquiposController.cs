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
    public class EquiposController : Controller
    {
        private nba_projectContext db = new nba_projectContext();

        // GET: Equipos
        public ActionResult Index()
        {
            var equipos = db.Equipos.Include(e => e.Division).Include(e => e.Estado);
            return View(equipos.ToList());
        }

        // GET: Equipos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Equipo equipo = db.Equipos.Find(id);
            if (equipo == null)
            {
                return HttpNotFound();
            }
            return View(equipo);
        }

        // GET: Equipos/Create
        public ActionResult Create()
        {
            ViewBag.DivisionID = new SelectList(db.Divisions, "DivisionID", "Name");
            ViewBag.EstadoID = new SelectList(db.Estados, "EstadoID", "Name");
            return View();
        }

        // POST: Equipos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EquipoID,Name,DivisionID,EstadoID")] Equipo equipo)
        {
            if (ModelState.IsValid)
            {
                db.Equipos.Add(equipo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DivisionID = new SelectList(db.Divisions, "DivisionID", "Name", equipo.DivisionID);
            ViewBag.EstadoID = new SelectList(db.Estados, "EstadoID", "Name", equipo.EstadoID);
            return View(equipo);
        }

        // GET: Equipos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Equipo equipo = db.Equipos.Find(id);
            if (equipo == null)
            {
                return HttpNotFound();
            }
            ViewBag.DivisionID = new SelectList(db.Divisions, "DivisionID", "Name", equipo.DivisionID);
            ViewBag.EstadoID = new SelectList(db.Estados, "EstadoID", "Name", equipo.EstadoID);
            return View(equipo);
        }

        // POST: Equipos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EquipoID,Name,DivisionID,EstadoID")] Equipo equipo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(equipo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DivisionID = new SelectList(db.Divisions, "DivisionID", "Name", equipo.DivisionID);
            ViewBag.EstadoID = new SelectList(db.Estados, "EstadoID", "Name", equipo.EstadoID);
            return View(equipo);
        }

        // GET: Equipos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Equipo equipo = db.Equipos.Find(id);
            if (equipo == null)
            {
                return HttpNotFound();
            }
            return View(equipo);
        }

        // POST: Equipos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Equipo equipo = db.Equipos.Find(id);
            db.Equipos.Remove(equipo);
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
