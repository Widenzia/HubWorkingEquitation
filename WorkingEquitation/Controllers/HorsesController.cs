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
    public class HorsesController : Controller
    {
        private WEContext db = new WEContext();

        // GET: Horses
        public ActionResult Index()
        {
            return View(db.db_Horses.ToList());
        }

        // GET: Horses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Horse horse = db.db_Horses.Find(id);
            if (horse == null)
            {
                return HttpNotFound();
            }
            return View(horse);
        }

        // GET: Horses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Horses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MeetingId,HorseId,HorseName")] Horse horse)
        {
            if (ModelState.IsValid)
            {
                db.db_Horses.Add(horse);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(horse);
        }

        // GET: Horses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Horse horse = db.db_Horses.Find(id);
            if (horse == null)
            {
                return HttpNotFound();
            }
            return View(horse);
        }

        // POST: Horses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MeetingId,HorseId,HorseName")] Horse horse)
        {
            if (ModelState.IsValid)
            {
                db.Entry(horse).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(horse);
        }

        // GET: Horses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Horse horse = db.db_Horses.Find(id);
            if (horse == null)
            {
                return HttpNotFound();
            }
            return View(horse);
        }

        // POST: Horses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Horse horse = db.db_Horses.Find(id);
            db.db_Horses.Remove(horse);
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
