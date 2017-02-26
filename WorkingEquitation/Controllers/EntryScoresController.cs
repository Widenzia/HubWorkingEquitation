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
    public class EntryScoresController : Controller
    {
        private WEContext db = new WEContext();

        // GET: EntryScores
        public ActionResult Index()
        {
            return View(db.db_EntryScores.ToList());
        }

        // GET: EntryScores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntryScore entryScore = db.db_EntryScores.Find(id);
            if (entryScore == null)
            {
                return HttpNotFound();
            }
            return View(entryScore);
        }

        // GET: EntryScores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EntryScores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MeetingId,ClassId,EntryId,EntryScoreId,CrewId,Position,TotalPoints,PointsPercent")] EntryScore entryScore)
        {
            if (ModelState.IsValid)
            {
                db.db_EntryScores.Add(entryScore);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(entryScore);
        }

        // GET: EntryScores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntryScore entryScore = db.db_EntryScores.Find(id);
            if (entryScore == null)
            {
                return HttpNotFound();
            }
            return View(entryScore);
        }

        // POST: EntryScores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MeetingId,ClassId,EntryId,EntryScoreId,CrewId,Position,TotalPoints,PointsPercent")] EntryScore entryScore)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entryScore).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(entryScore);
        }

        // GET: EntryScores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntryScore entryScore = db.db_EntryScores.Find(id);
            if (entryScore == null)
            {
                return HttpNotFound();
            }
            return View(entryScore);
        }

        // POST: EntryScores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EntryScore entryScore = db.db_EntryScores.Find(id);
            db.db_EntryScores.Remove(entryScore);
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
