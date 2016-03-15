using BrewrMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrewrMVC.Controllers
{
    public class NowBrewingController : Controller
    {
        private readonly BrewRepository _db = new BrewRepository();

        [HttpGet]
        public ActionResult Index()
        {
            List<Brew> brews = _db.GetAllWhereInComplete();
            return View(brews);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var brew = _db.FindById(id);
            return View(brew);
        }

        [HttpPost, ActionName("Edit")]
        public ActionResult EditBrew([Bind(Include = "ID,Name,Type,BrewDate,Secondaried,Bottled,UserId,Complete")]Brew brew)
        {
            _db.EditBrew(brew);
            return RedirectToAction("Index");
        }
    }
}