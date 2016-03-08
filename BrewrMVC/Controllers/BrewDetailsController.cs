using BrewrMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BrewrMVC.Controllers
{
    public class BrewDetailsController : Controller
    {
        private readonly BrewDetailsRepository _repo = new BrewDetailsRepository();
        // GET: BrewDetails
        public ActionResult Index(int id)
        {
            Mash mashes = _repo.GetAll(id);
            return View(mashes);
        }
    }
}