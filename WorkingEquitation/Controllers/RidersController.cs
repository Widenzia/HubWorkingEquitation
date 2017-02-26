using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WorkingEquitation.DataAccessLayer;
using WorkingEquitation.Models;

namespace WorkingEquitation.Controllers
{
    public class RidersController : Controller
    {
        private WEContext db = new WEContext();

        // GET: Riders
        public ActionResult Index()
        {
            var db_Riders = db.db_Riders.Include(r => r.Horse);
            return View(db_Riders.ToList());
        }

        // GET: Riders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rider rider = db.db_Riders.Find(id);
            if (rider == null)
            {
                return HttpNotFound();
            }
            return View(rider);
        }

        // GET: Riders/Create
        public ActionResult Create()
        {
            ViewBag.MeetingId = new SelectList(db.db_Horses, "MeetingId", "HorseName");
            return View();
        }

        // POST: Riders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MeetingId,RiderId,FirstName,LastName,ClubTeam,HorseId")] Rider rider)
        {
            if (ModelState.IsValid)
            {
                db.db_Riders.Add(rider);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MeetingId = new SelectList(db.db_Horses, "MeetingId", "HorseName", rider.MeetingId);
            return View(rider);
        }

        // GET: Riders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rider rider = db.db_Riders.Find(id);
            if (rider == null)
            {
                return HttpNotFound();
            }
            ViewBag.MeetingId = new SelectList(db.db_Horses, "MeetingId", "HorseName", rider.MeetingId);
            return View(rider);
        }

        // POST: Riders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MeetingId,RiderId,FirstName,LastName,ClubTeam,HorseId")] Rider rider)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rider).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MeetingId = new SelectList(db.db_Horses, "MeetingId", "HorseName", rider.MeetingId);
            return View(rider);
        }

        // GET: Riders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rider rider = db.db_Riders.Find(id);
            if (rider == null)
            {
                return HttpNotFound();
            }
            return View(rider);
        }

        // POST: Riders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rider rider = db.db_Riders.Find(id);
            db.db_Riders.Remove(rider);
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
