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
    public class Product_Sales_for_1997Controller : Controller
    {
        private NorthwindDM db = new NorthwindDM();

        // GET: Product_Sales_for_1997
        public ActionResult Index()
        {
            return View(db.Product_Sales_for_1997.ToList());
        }

        // GET: Product_Sales_for_1997/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product_Sales_for_1997 product_Sales_for_1997 = db.Product_Sales_for_1997.Find(id);
            if (product_Sales_for_1997 == null)
            {
                return HttpNotFound();
            }
            return View(product_Sales_for_1997);
        }

        // GET: Product_Sales_for_1997/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product_Sales_for_1997/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CategoryName,ProductName,ProductSales")] Product_Sales_for_1997 product_Sales_for_1997)
        {
            if (ModelState.IsValid)
            {
                db.Product_Sales_for_1997.Add(product_Sales_for_1997);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product_Sales_for_1997);
        }

        // GET: Product_Sales_for_1997/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product_Sales_for_1997 product_Sales_for_1997 = db.Product_Sales_for_1997.Find(id);
            if (product_Sales_for_1997 == null)
            {
                return HttpNotFound();
            }
            return View(product_Sales_for_1997);
        }

        // POST: Product_Sales_for_1997/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CategoryName,ProductName,ProductSales")] Product_Sales_for_1997 product_Sales_for_1997)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product_Sales_for_1997).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product_Sales_for_1997);
        }

        // GET: Product_Sales_for_1997/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Product_Sales_for_1997 product_Sales_for_1997 = db.Product_Sales_for_1997.Find(id);
            if (product_Sales_for_1997 == null)
            {
                return HttpNotFound();
            }
            return View(product_Sales_for_1997);
        }

        // POST: Product_Sales_for_1997/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Product_Sales_for_1997 product_Sales_for_1997 = db.Product_Sales_for_1997.Find(id);
            db.Product_Sales_for_1997.Remove(product_Sales_for_1997);
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
