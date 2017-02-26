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
    public class MeetingCrewsController : Controller
    {
        private WEContext db = new WEContext();

        // GET: MeetingCrews
        public ActionResult Index()
        {
            return View(db.db_MeetingCrews.ToList());
        }

        // GET: MeetingCrews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeetingCrew meetingCrew = db.db_MeetingCrews.Find(id);
            if (meetingCrew == null)
            {
                return HttpNotFound();
            }
            return View(meetingCrew);
        }

        // GET: MeetingCrews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MeetingCrews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MeetingCrewId,MeetingId,CrewId,FirstName,LastName,PhoneNo,Email")] MeetingCrew meetingCrew)
        {
            if (ModelState.IsValid)
            {
                db.db_MeetingCrews.Add(meetingCrew);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(meetingCrew);
        }

        // GET: MeetingCrews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeetingCrew meetingCrew = db.db_MeetingCrews.Find(id);
            if (meetingCrew == null)
            {
                return HttpNotFound();
            }
            return View(meetingCrew);
        }

        // POST: MeetingCrews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MeetingCrewId,MeetingId,CrewId,FirstName,LastName,PhoneNo,Email")] MeetingCrew meetingCrew)
        {
            if (ModelState.IsValid)
            {
                db.Entry(meetingCrew).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(meetingCrew);
        }

        // GET: MeetingCrews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MeetingCrew meetingCrew = db.db_MeetingCrews.Find(id);
            if (meetingCrew == null)
            {
                return HttpNotFound();
            }
            return View(meetingCrew);
        }

        // POST: MeetingCrews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MeetingCrew meetingCrew = db.db_MeetingCrews.Find(id);
            db.db_MeetingCrews.Remove(meetingCrew);
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
