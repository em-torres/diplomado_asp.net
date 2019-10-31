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
    public class Products_by_CategoryController : Controller
    {
        private NorthwindDM db = new NorthwindDM();

        // GET: Products_by_Category
        public ActionResult Index()
        {
            return View(db.Products_by_Category.ToList());
        }

        // GET: Products_by_Category/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products_by_Category products_by_Category = db.Products_by_Category.Find(id);
            if (products_by_Category == null)
            {
                return HttpNotFound();
            }
            return View(products_by_Category);
        }

        // GET: Products_by_Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products_by_Category/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CategoryName,ProductName,Discontinued,QuantityPerUnit,UnitsInStock")] Products_by_Category products_by_Category)
        {
            if (ModelState.IsValid)
            {
                db.Products_by_Category.Add(products_by_Category);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(products_by_Category);
        }

        // GET: Products_by_Category/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products_by_Category products_by_Category = db.Products_by_Category.Find(id);
            if (products_by_Category == null)
            {
                return HttpNotFound();
            }
            return View(products_by_Category);
        }

        // POST: Products_by_Category/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CategoryName,ProductName,Discontinued,QuantityPerUnit,UnitsInStock")] Products_by_Category products_by_Category)
        {
            if (ModelState.IsValid)
            {
                db.Entry(products_by_Category).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(products_by_Category);
        }

        // GET: Products_by_Category/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products_by_Category products_by_Category = db.Products_by_Category.Find(id);
            if (products_by_Category == null)
            {
                return HttpNotFound();
            }
            return View(products_by_Category);
        }

        // POST: Products_by_Category/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Products_by_Category products_by_Category = db.Products_by_Category.Find(id);
            db.Products_by_Category.Remove(products_by_Category);
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
