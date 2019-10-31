using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using practica_northwind.Models;

namespace practica_northwind.Controllers
{
    public class Current_Product_ListController : Controller
    {
        private NorthwindDM db = new NorthwindDM();

        // GET: Current_Product_List
        public ActionResult Index()
        {
            return View(db.Current_Product_List.ToList());
        }

        // GET: Current_Product_List/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Current_Product_List current_Product_List = db.Current_Product_List.Find(id);
            if (current_Product_List == null)
            {
                return HttpNotFound();
            }
            return View(current_Product_List);
        }

        // GET: Current_Product_List/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Current_Product_List/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductID,ProductName")] Current_Product_List current_Product_List)
        {
            if (ModelState.IsValid)
            {
                db.Current_Product_List.Add(current_Product_List);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(current_Product_List);
        }

        // GET: Current_Product_List/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Current_Product_List current_Product_List = db.Current_Product_List.Find(id);
            if (current_Product_List == null)
            {
                return HttpNotFound();
            }
            return View(current_Product_List);
        }

        // POST: Current_Product_List/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductID,ProductName")] Current_Product_List current_Product_List)
        {
            if (ModelState.IsValid)
            {
                db.Entry(current_Product_List).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(current_Product_List);
        }

        // GET: Current_Product_List/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Current_Product_List current_Product_List = db.Current_Product_List.Find(id);
            if (current_Product_List == null)
            {
                return HttpNotFound();
            }
            return View(current_Product_List);
        }

        // POST: Current_Product_List/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Current_Product_List current_Product_List = db.Current_Product_List.Find(id);
            db.Current_Product_List.Remove(current_Product_List);
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
