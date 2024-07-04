using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Tdtless10c.Models;

namespace Tdtless10c.Controllers
{
    public class TdtProductsController : Controller
    {
        private tdtK22cnt3lession10cEntities db = new tdtK22cnt3lession10cEntities();

        // GET: TdtProducts
        public ActionResult TdtIndex()
        {
            return View(db.TdtProduct.ToList());
        }

        // GET: TdtProducts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TdtProduct tdtProduct = db.TdtProduct.Find(id);
            if (tdtProduct == null)
            {
                return HttpNotFound();
            }
            return View(tdtProduct);
        }

        // GET: TdtProducts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TdtProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TdtId2210900134,TdtProName,TdtQty,TdtPrice,TdtCateId,TdtActive")] TdtProduct tdtProduct)
        {
            if (ModelState.IsValid)
            {
                db.TdtProduct.Add(tdtProduct);
                db.SaveChanges();
                return RedirectToAction("TdtIndex");
            }

            return View(tdtProduct);
        }

        // GET: TdtProducts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TdtProduct tdtProduct = db.TdtProduct.Find(id);
            if (tdtProduct == null)
            {
                return HttpNotFound();
            }
            return View(tdtProduct);
        }

        // POST: TdtProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TdtId2210900134,TdtProName,TdtQty,TdtPrice,TdtCateId,TdtActive")] TdtProduct tdtProduct)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tdtProduct).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("TdtIndex");
            }
            return View(tdtProduct);
        }

        // GET: TdtProducts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TdtProduct tdtProduct = db.TdtProduct.Find(id);
            if (tdtProduct == null)
            {
                return HttpNotFound();
            }
            return View(tdtProduct);
        }

        // POST: TdtProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TdtProduct tdtProduct = db.TdtProduct.Find(id);
            db.TdtProduct.Remove(tdtProduct);
            db.SaveChanges();
            return RedirectToAction("TdtIndex");
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
