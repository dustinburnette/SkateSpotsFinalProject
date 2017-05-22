using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SkateSpotsFinalProject.Models;

namespace SkateSpotsFinalProject.Controllers
{
    public class SkateLoggersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: SkateLoggers
        public ActionResult Index()
        {
            return View(db.SkateLoggers.ToList());
        }

        // GET: SkateLoggers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SkateLogger skateLogger = db.SkateLoggers.Find(id);
            if (skateLogger == null)
            {
                return HttpNotFound();
            }
            return View(skateLogger);
        }

        // GET: SkateLoggers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SkateLoggers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SkateLoggerID,TrickName,Attempts,Landed,HowLongMinutes")] SkateLogger skateLogger)
        {
            if (ModelState.IsValid)
            {
                db.SkateLoggers.Add(skateLogger);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(skateLogger);
        }

        // GET: SkateLoggers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SkateLogger skateLogger = db.SkateLoggers.Find(id);
            if (skateLogger == null)
            {
                return HttpNotFound();
            }
            return View(skateLogger);
        }

        // POST: SkateLoggers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SkateLoggerID,TrickName,Attempts,Landed,HowLongMinutes")] SkateLogger skateLogger)
        {
            if (ModelState.IsValid)
            {
                db.Entry(skateLogger).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(skateLogger);
        }

        // GET: SkateLoggers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SkateLogger skateLogger = db.SkateLoggers.Find(id);
            if (skateLogger == null)
            {
                return HttpNotFound();
            }
            return View(skateLogger);
        }

        // POST: SkateLoggers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SkateLogger skateLogger = db.SkateLoggers.Find(id);
            db.SkateLoggers.Remove(skateLogger);
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
