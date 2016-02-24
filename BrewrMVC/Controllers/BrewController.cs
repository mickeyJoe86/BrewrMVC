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

        [HttpGet]
        public ActionResult Edit(int id)
        {
            Brew brew = _db.FindById(id);
            return View(brew);
        }

        [HttpPost, ActionName("Edit")]
        public ActionResult EditBrew([Bind(Include = "ID,Name,Type,BrewDate,Secondaried,Bottled")]Brew brew)
        {
            _db.EditBrew(brew);
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Brew brew = _db.FindById(id);
            return View(brew);
        }
        
        [HttpPost, ActionName("Delete")]        
        public ActionResult DeleteConfirmed(int id)
        {
            _db.DeleteBrew(id);
            return RedirectToAction("Index");
        }
    }
}