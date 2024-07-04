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
    public class TdtCategoriesController : Controller
    {
        private tdtK22cnt3lession10cEntities db = new tdtK22cnt3lession10cEntities();

        // GET: TdtCategories
        public ActionResult TdtIndex()
        {
            return View(db.TdtCategory.ToList());
        }

        // GET: TdtCategories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TdtCategory tdtCategory = db.TdtCategory.Find(id);
            if (tdtCategory == null)
            {
                return HttpNotFound();
            }
            return View(tdtCategory);
        }

        // GET: TdtCategories/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TdtCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TdtID,TdtCateName,TdtStatus")] TdtCategory tdtCategory)
        {
            if (ModelState.IsValid)
            {
                db.TdtCategory.Add(tdtCategory);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tdtCategory);
        }

        // GET: TdtCategories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TdtCategory tdtCategory = db.TdtCategory.Find(id);
            if (tdtCategory == null)
            {
                return HttpNotFound();
            }
            return View(tdtCategory);
        }

        // POST: TdtCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TdtID,TdtCateName,TdtStatus")] TdtCategory tdtCategory)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tdtCategory).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tdtCategory);
        }

        // GET: TdtCategories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TdtCategory tdtCategory = db.TdtCategory.Find(id);
            if (tdtCategory == null)
            {
                return HttpNotFound();
            }
            return View(tdtCategory);
        }

        // POST: TdtCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TdtCategory tdtCategory = db.TdtCategory.Find(id);
            db.TdtCategory.Remove(tdtCategory);
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
