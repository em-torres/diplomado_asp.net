﻿using System;
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
    public class CustomerDemographicsController : Controller
    {
        private NorthwindDM db = new NorthwindDM();

        // GET: CustomerDemographics
        public ActionResult Index()
        {
            return View(db.CustomerDemographics.ToList());
        }

        // GET: CustomerDemographics/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerDemographics customerDemographics = db.CustomerDemographics.Find(id);
            if (customerDemographics == null)
            {
                return HttpNotFound();
            }
            return View(customerDemographics);
        }

        // GET: CustomerDemographics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerDemographics/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CustomerTypeID,CustomerDesc")] CustomerDemographics customerDemographics)
        {
            if (ModelState.IsValid)
            {
                db.CustomerDemographics.Add(customerDemographics);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(customerDemographics);
        }

        // GET: CustomerDemographics/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerDemographics customerDemographics = db.CustomerDemographics.Find(id);
            if (customerDemographics == null)
            {
                return HttpNotFound();
            }
            return View(customerDemographics);
        }

        // POST: CustomerDemographics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CustomerTypeID,CustomerDesc")] CustomerDemographics customerDemographics)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customerDemographics).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(customerDemographics);
        }

        // GET: CustomerDemographics/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CustomerDemographics customerDemographics = db.CustomerDemographics.Find(id);
            if (customerDemographics == null)
            {
                return HttpNotFound();
            }
            return View(customerDemographics);
        }

        // POST: CustomerDemographics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CustomerDemographics customerDemographics = db.CustomerDemographics.Find(id);
            db.CustomerDemographics.Remove(customerDemographics);
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
