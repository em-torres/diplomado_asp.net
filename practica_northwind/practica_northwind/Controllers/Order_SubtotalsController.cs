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
    public class Order_SubtotalsController : Controller
    {
        private NorthwindDM db = new NorthwindDM();

        // GET: Order_Subtotals
        public ActionResult Index()
        {
            return View(db.Order_Subtotals.ToList());
        }

        // GET: Order_Subtotals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order_Subtotals order_Subtotals = db.Order_Subtotals.Find(id);
            if (order_Subtotals == null)
            {
                return HttpNotFound();
            }
            return View(order_Subtotals);
        }

        // GET: Order_Subtotals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Order_Subtotals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OrderID,Subtotal")] Order_Subtotals order_Subtotals)
        {
            if (ModelState.IsValid)
            {
                db.Order_Subtotals.Add(order_Subtotals);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(order_Subtotals);
        }

        // GET: Order_Subtotals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order_Subtotals order_Subtotals = db.Order_Subtotals.Find(id);
            if (order_Subtotals == null)
            {
                return HttpNotFound();
            }
            return View(order_Subtotals);
        }

        // POST: Order_Subtotals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OrderID,Subtotal")] Order_Subtotals order_Subtotals)
        {
            if (ModelState.IsValid)
            {
                db.Entry(order_Subtotals).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(order_Subtotals);
        }

        // GET: Order_Subtotals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order_Subtotals order_Subtotals = db.Order_Subtotals.Find(id);
            if (order_Subtotals == null)
            {
                return HttpNotFound();
            }
            return View(order_Subtotals);
        }

        // POST: Order_Subtotals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Order_Subtotals order_Subtotals = db.Order_Subtotals.Find(id);
            db.Order_Subtotals.Remove(order_Subtotals);
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
