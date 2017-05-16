using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using SkateSpotsFinalProject.Models;

namespace SkateSpotsFinalProject.Controllers
{
    public class SkateSpotsApiController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/SkateSpotsApi
        public IQueryable<SkateSpot> GetSkateSpots()
        {
            return db.SkateSpots;
        }

        // GET: api/SkateSpotsApi/5
        [ResponseType(typeof(SkateSpot))]
        public IHttpActionResult GetSkateSpot(int id)
        {
            SkateSpot skateSpot = db.SkateSpots.Find(id);
            if (skateSpot == null)
            {
                return NotFound();
            }

            return Ok(skateSpot);
        }

        // PUT: api/SkateSpotsApi/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutSkateSpot(int id, SkateSpot skateSpot)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != skateSpot.SkateSpotID)
            {
                return BadRequest();
            }

            db.Entry(skateSpot).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SkateSpotExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/SkateSpotsApi
        [ResponseType(typeof(SkateSpot))]
        public IHttpActionResult PostSkateSpot(SkateSpot skateSpot)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.SkateSpots.Add(skateSpot);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = skateSpot.SkateSpotID }, skateSpot);
        }

        // DELETE: api/SkateSpotsApi/5
        [ResponseType(typeof(SkateSpot))]
        public IHttpActionResult DeleteSkateSpot(int id)
        {
            SkateSpot skateSpot = db.SkateSpots.Find(id);
            if (skateSpot == null)
            {
                return NotFound();
            }

            db.SkateSpots.Remove(skateSpot);
            db.SaveChanges();

            return Ok(skateSpot);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SkateSpotExists(int id)
        {
            return db.SkateSpots.Count(e => e.SkateSpotID == id) > 0;
        }
    }
}