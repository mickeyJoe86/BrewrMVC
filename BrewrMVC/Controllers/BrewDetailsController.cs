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
            BrewDetailsViewModel details = _repo.GetFullInfo(id);
            return View(details);
        }
    }
}