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
    public class Category_Sales_for_1997Controller : Controller
    {
        private NorthwindDM db = new NorthwindDM();

        // GET: Category_Sales_for_1997
        public ActionResult Index()
        {
            return View(db.Category_Sales_for_1997.ToList());
        }

        // GET: Category_Sales_for_1997/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category_Sales_for_1997 category_Sales_for_1997 = db.Category_Sales_for_1997.Find(id);
            if (category_Sales_for_1997 == null)
            {
                return HttpNotFound();
            }
            return View(category_Sales_for_1997);
        }

        // GET: Category_Sales_for_1997/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category_Sales_for_1997/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CategoryName,CategorySales")] Category_Sales_for_1997 category_Sales_for_1997)
        {
            if (ModelState.IsValid)
            {
                db.Category_Sales_for_1997.Add(category_Sales_for_1997);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(category_Sales_for_1997);
        }

        // GET: Category_Sales_for_1997/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category_Sales_for_1997 category_Sales_for_1997 = db.Category_Sales_for_1997.Find(id);
            if (category_Sales_for_1997 == null)
            {
                return HttpNotFound();
            }
            return View(category_Sales_for_1997);
        }

        // POST: Category_Sales_for_1997/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CategoryName,CategorySales")] Category_Sales_for_1997 category_Sales_for_1997)
        {
            if (ModelState.IsValid)
            {
                db.Entry(category_Sales_for_1997).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category_Sales_for_1997);
        }

        // GET: Category_Sales_for_1997/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Category_Sales_for_1997 category_Sales_for_1997 = db.Category_Sales_for_1997.Find(id);
            if (category_Sales_for_1997 == null)
            {
                return HttpNotFound();
            }
            return View(category_Sales_for_1997);
        }

        // POST: Category_Sales_for_1997/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Category_Sales_for_1997 category_Sales_for_1997 = db.Category_Sales_for_1997.Find(id);
            db.Category_Sales_for_1997.Remove(category_Sales_for_1997);
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
