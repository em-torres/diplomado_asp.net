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
    public class Orders_QryController : Controller
    {
        private NorthwindDM db = new NorthwindDM();

        // GET: Orders_Qry
        public ActionResult Index()
        {
            return View(db.Orders_Qry.ToList());
        }

        // GET: Orders_Qry/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Orders_Qry orders_Qry = db.Orders_Qry.Find(id);
            if (orders_Qry == null)
            {
                return HttpNotFound();
            }
            return View(orders_Qry);
        }

        // GET: Orders_Qry/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Orders_Qry/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrderID,CompanyName,CustomerID,EmployeeID,OrderDate,RequiredDate,ShippedDate,ShipVia,Freight,ShipName,ShipAddress,ShipCity,ShipRegion,ShipPostalCode,ShipCountry,Address,City,Region,PostalCode,Country")] Orders_Qry orders_Qry)
        {
            if (ModelState.IsValid)
            {
                db.Orders_Qry.Add(orders_Qry);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(orders_Qry);
        }

        // GET: Orders_Qry/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Orders_Qry orders_Qry = db.Orders_Qry.Find(id);
            if (orders_Qry == null)
            {
                return HttpNotFound();
            }
            return View(orders_Qry);
        }

        // POST: Orders_Qry/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrderID,CompanyName,CustomerID,EmployeeID,OrderDate,RequiredDate,ShippedDate,ShipVia,Freight,ShipName,ShipAddress,ShipCity,ShipRegion,ShipPostalCode,ShipCountry,Address,City,Region,PostalCode,Country")] Orders_Qry orders_Qry)
        {
            if (ModelState.IsValid)
            {
                db.Entry(orders_Qry).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(orders_Qry);
        }

        // GET: Orders_Qry/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Orders_Qry orders_Qry = db.Orders_Qry.Find(id);
            if (orders_Qry == null)
            {
                return HttpNotFound();
            }
            return View(orders_Qry);
        }

        // POST: Orders_Qry/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Orders_Qry orders_Qry = db.Orders_Qry.Find(id);
            db.Orders_Qry.Remove(orders_Qry);
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
