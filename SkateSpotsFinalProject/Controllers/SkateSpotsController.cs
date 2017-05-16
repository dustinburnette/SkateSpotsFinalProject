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
    public class SkateSpotsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: SkateSpots
        public ActionResult Index()
        {
            return View(new SkateSpot());
        }

        // GET: SkateSpots/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SkateSpot skateSpot = db.SkateSpots.Find(id);
            if (skateSpot == null)
            {
                return HttpNotFound();
            }
            return View(skateSpot);
        }

        // GET: SkateSpots/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SkateSpots/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SkateSpotID,Description,Lat,Long,ShortDescription")] SkateSpot skateSpot)
        {
            if (ModelState.IsValid)
            {
                db.SkateSpots.Add(skateSpot);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(skateSpot);
        }

        // GET: SkateSpots/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SkateSpot skateSpot = db.SkateSpots.Find(id);
            if (skateSpot == null)
            {
                return HttpNotFound();
            }
            return View(skateSpot);
        }

        // POST: SkateSpots/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SkateSpotID,Description,Lat,Long")] SkateSpot skateSpot)
        {
            if (ModelState.IsValid)
            {
                db.Entry(skateSpot).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(skateSpot);
        }

        // GET: SkateSpots/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SkateSpot skateSpot = db.SkateSpots.Find(id);
            if (skateSpot == null)
            {
                return HttpNotFound();
            }
            return View(skateSpot);
        }

        // POST: SkateSpots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            SkateSpot skateSpot = db.SkateSpots.Find(id);
            db.SkateSpots.Remove(skateSpot);
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
