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
    public class Customer_and_Suppliers_by_CityController : Controller
    {
        private NorthwindDM db = new NorthwindDM();

        // GET: Customer_and_Suppliers_by_City
        public ActionResult Index()
        {
            return View(db.Customer_and_Suppliers_by_City.ToList());
        }

        // GET: Customer_and_Suppliers_by_City/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer_and_Suppliers_by_City customer_and_Suppliers_by_City = db.Customer_and_Suppliers_by_City.Find(id);
            if (customer_and_Suppliers_by_City == null)
            {
                return HttpNotFound();
            }
            return View(customer_and_Suppliers_by_City);
        }

        // GET: Customer_and_Suppliers_by_City/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer_and_Suppliers_by_City/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CompanyName,Relationship,City,ContactName")] Customer_and_Suppliers_by_City customer_and_Suppliers_by_City)
        {
            if (ModelState.IsValid)
            {
                db.Customer_and_Suppliers_by_City.Add(customer_and_Suppliers_by_City);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customer_and_Suppliers_by_City);
        }

        // GET: Customer_and_Suppliers_by_City/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer_and_Suppliers_by_City customer_and_Suppliers_by_City = db.Customer_and_Suppliers_by_City.Find(id);
            if (customer_and_Suppliers_by_City == null)
            {
                return HttpNotFound();
            }
            return View(customer_and_Suppliers_by_City);
        }

        // POST: Customer_and_Suppliers_by_City/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CompanyName,Relationship,City,ContactName")] Customer_and_Suppliers_by_City customer_and_Suppliers_by_City)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer_and_Suppliers_by_City).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customer_and_Suppliers_by_City);
        }

        // GET: Customer_and_Suppliers_by_City/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer_and_Suppliers_by_City customer_and_Suppliers_by_City = db.Customer_and_Suppliers_by_City.Find(id);
            if (customer_and_Suppliers_by_City == null)
            {
                return HttpNotFound();
            }
            return View(customer_and_Suppliers_by_City);
        }

        // POST: Customer_and_Suppliers_by_City/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Customer_and_Suppliers_by_City customer_and_Suppliers_by_City = db.Customer_and_Suppliers_by_City.Find(id);
            db.Customer_and_Suppliers_by_City.Remove(customer_and_Suppliers_by_City);
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
