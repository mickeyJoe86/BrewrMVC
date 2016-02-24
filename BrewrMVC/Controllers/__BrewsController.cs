using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BrewrMVC.Models;

namespace BrewrMVC.Controllers
{
    public class __BrewsController : Controller
    {
        private BrewContext db = new BrewContext();

        // GET: Brews
        public ActionResult Index()
        {
            return View(db.Brews.ToList());
        }

        // GET: Brews/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Brew brew = db.Brews.Find(id);
            if (brew == null)
            {
                return HttpNotFound();
            }
            return View(brew);
        }

        // GET: Brews/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Brews/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,Type,BrewDate,Secondaried,Bottled")] Brew brew)
        {
            if (ModelState.IsValid)
            {
                db.Brews.Add(brew);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(brew);
        }

        // GET: Brews/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Brew brew = db.Brews.Find(id);
            if (brew == null)
            {
                return HttpNotFound();
            }
            return View(brew);
        }

        // POST: Brews/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Type,BrewDate,Secondaried,Bottled")] Brew brew)
        {
            if (ModelState.IsValid)
            {
                db.Entry(brew).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(brew);
        }

        // GET: Brews/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Brew brew = db.Brews.Find(id);
            if (brew == null)
            {
                return HttpNotFound();
            }
            return View(brew);
        }

        // POST: Brews/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Brew brew = db.Brews.Find(id);
            db.Brews.Remove(brew);
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
