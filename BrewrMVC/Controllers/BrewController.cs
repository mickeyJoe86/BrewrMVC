using BrewrMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace BrewrMVC.Controllers
{
    public class BrewController : Controller
    {
        private readonly BrewRepository _db = new BrewRepository();
        public ActionResult Index()
        {
            List<Brew> model = _db.GetAll();
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create([Bind()]Brew brew)
        {
            if (ModelState.IsValid)
            {
                _db.AddNewBrew(brew);
                return RedirectToAction("Index");
            }

            return View("Create");
        }

        // GET: Brews/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Brew brew = _db.FindById(id);

            return View(brew);
        }

        // POST: Brews/Delete/5
        [HttpPost, ActionName("Delete")]        
        public ActionResult DeleteConfirmed(int id)
        {
            _db.DeleteBrew(id);
            return RedirectToAction("Index");
        }
    }
}