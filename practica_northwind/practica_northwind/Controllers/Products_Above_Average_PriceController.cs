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
    public class Products_Above_Average_PriceController : Controller
    {
        private NorthwindDM db = new NorthwindDM();

        // GET: Products_Above_Average_Price
        public ActionResult Index()
        {
            return View(db.Products_Above_Average_Price.ToList());
        }

        // GET: Products_Above_Average_Price/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products_Above_Average_Price products_Above_Average_Price = db.Products_Above_Average_Price.Find(id);
            if (products_Above_Average_Price == null)
            {
                return HttpNotFound();
            }
            return View(products_Above_Average_Price);
        }

        // GET: Products_Above_Average_Price/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Products_Above_Average_Price/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProductName,UnitPrice")] Products_Above_Average_Price products_Above_Average_Price)
        {
            if (ModelState.IsValid)
            {
                db.Products_Above_Average_Price.Add(products_Above_Average_Price);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(products_Above_Average_Price);
        }

        // GET: Products_Above_Average_Price/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products_Above_Average_Price products_Above_Average_Price = db.Products_Above_Average_Price.Find(id);
            if (products_Above_Average_Price == null)
            {
                return HttpNotFound();
            }
            return View(products_Above_Average_Price);
        }

        // POST: Products_Above_Average_Price/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProductName,UnitPrice")] Products_Above_Average_Price products_Above_Average_Price)
        {
            if (ModelState.IsValid)
            {
                db.Entry(products_Above_Average_Price).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(products_Above_Average_Price);
        }

        // GET: Products_Above_Average_Price/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products_Above_Average_Price products_Above_Average_Price = db.Products_Above_Average_Price.Find(id);
            if (products_Above_Average_Price == null)
            {
                return HttpNotFound();
            }
            return View(products_Above_Average_Price);
        }

        // POST: Products_Above_Average_Price/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Products_Above_Average_Price products_Above_Average_Price = db.Products_Above_Average_Price.Find(id);
            db.Products_Above_Average_Price.Remove(products_Above_Average_Price);
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
