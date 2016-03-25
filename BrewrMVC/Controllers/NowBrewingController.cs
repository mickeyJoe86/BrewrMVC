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
        private readonly NowBrewingRepository _nowBrewing = new NowBrewingRepository();

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

        [HttpGet]
        public ActionResult StartMash(int id)
        {
            var vm = _nowBrewing.StartMashes(id);
            return View(vm);
        }

        [HttpPost]
        public ActionResult CreateMash([Bind()]MashDetailsViewModel mash)
        {
            _nowBrewing.AddNewMash(mash);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditMash(int id)
        {
            MashDetailsViewModel mash = _nowBrewing.StartMashes(id);
            if(mash.MashesObject == null)
            {
                return RedirectToAction("StartMash", new { Id = id});
            }
            return View(mash);
        }

        [HttpPost]
        public ActionResult SaveMash([Bind()]MashDetailsViewModel mashDetails)
        {
            _nowBrewing.SaveMash(mashDetails);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult EditFermentation(int id)
        {
            FermentDetailsViewModel ferments = _nowBrewing.StartFerments(id);
            if(ferments.FermentsObject == null)
            {
                return RedirectToAction("StartFerments", new { Id = id });
            }
            return View(ferments);
        }

        [HttpGet]
        public ActionResult StartFerments(int id)
        {
            var vm = _nowBrewing.StartFerments(id);
            return View(vm);
        }

        [HttpPost]
        public ActionResult CreateFerments([Bind()]FermentDetailsViewModel ferments)
        {
            _nowBrewing.AddNewFerments(ferments);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult SaveFerments([Bind()]FermentDetailsViewModel ferments)
        {
            _nowBrewing.SaveFerments(ferments);
            return RedirectToAction("Index");
        }
        //[HttpPost]
        //public ActionResult EditMash([Bind()]MashDetailsViewModel mashDetails)
        //{
        //    //_nowBrewing.SaveMashes(mashDetails);
        //    return RedirectToAction("Index");
        //}

        [HttpGet]
        public ActionResult Delete(int id)
        {
            _db.DeleteBrew(id);
            return RedirectToAction("Index");          
        }
    }
}