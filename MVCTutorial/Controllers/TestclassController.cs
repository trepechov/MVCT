using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCTutorial.DAL.Entities;
using MVCTutorial.DAL;

namespace MVCTutorial.Models
{
    public class TestclassController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: /TestclassController/
        public ActionResult Index()
        {
            return View(db.Testclasses.ToList());
        }

        // GET: /TestclassController/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Testclass testclass = db.Testclasses.Find(id);
            if (testclass == null)
            {
                return HttpNotFound();
            }
            return View(testclass);
        }

        // GET: /TestclassController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /TestclassController/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Price")] Testclass testclass)
        {
            if (ModelState.IsValid)
            {
                db.Testclasses.Add(testclass);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(testclass);
        }

        // GET: /TestclassController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Testclass testclass = db.Testclasses.Find(id);
            if (testclass == null)
            {
                return HttpNotFound();
            }
            return View(testclass);
        }

        // POST: /TestclassController/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Price")] Testclass testclass)
        {
            if (ModelState.IsValid)
            {
                db.Entry(testclass).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(testclass);
        }

        // GET: /TestclassController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Testclass testclass = db.Testclasses.Find(id);
            if (testclass == null)
            {
                return HttpNotFound();
            }
            return View(testclass);
        }

        // POST: /TestclassController/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Testclass testclass = db.Testclasses.Find(id);
            db.Testclasses.Remove(testclass);
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
