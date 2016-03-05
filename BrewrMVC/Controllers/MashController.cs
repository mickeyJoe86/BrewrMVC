using BrewrMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrewrMVC.Controllers
{
    public class MashController : Controller
    {
        private readonly MashRepository _repo = new MashRepository();
        // GET: Mash
        public ActionResult Index()
        {
            List<Mash> mashes = _repo.GetAll();
            return View(mashes);
        }
    }
}