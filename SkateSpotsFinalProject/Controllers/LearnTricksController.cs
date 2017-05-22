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
    public class LearnTricksController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: LearnTricks
        public ActionResult Index()
        {
            return View(db.LearnTricks.ToList());
        }

        // GET: LearnTricks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LearnTrick learnTrick = db.LearnTricks.Find(id);
            if (learnTrick == null)
            {
                return HttpNotFound();
            }
            return View(learnTrick);
        }

        // GET: LearnTricks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LearnTricks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LearnTrickID,TrickName")] LearnTrick learnTrick)
        {
            if (ModelState.IsValid)
            {
                db.LearnTricks.Add(learnTrick);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(learnTrick);
        }

        // GET: LearnTricks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LearnTrick learnTrick = db.LearnTricks.Find(id);
            if (learnTrick == null)
            {
                return HttpNotFound();
            }
            return View(learnTrick);
        }

        // POST: LearnTricks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LearnTrickID,TrickName")] LearnTrick learnTrick)
        {
            if (ModelState.IsValid)
            {
                db.Entry(learnTrick).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(learnTrick);
        }

        // GET: LearnTricks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LearnTrick learnTrick = db.LearnTricks.Find(id);
            if (learnTrick == null)
            {
                return HttpNotFound();
            }
            return View(learnTrick);
        }

        // POST: LearnTricks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LearnTrick learnTrick = db.LearnTricks.Find(id);
            db.LearnTricks.Remove(learnTrick);
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
