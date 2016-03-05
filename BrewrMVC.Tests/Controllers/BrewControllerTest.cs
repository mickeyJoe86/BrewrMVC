using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using BrewrMVC.Controllers;
using System.Collections.Generic;
using BrewrMVC.Models;

namespace BrewrMVC.Tests.Controllers
{
    [TestClass]
    public class BrewControllerTest
    {
        BrewController _brewController = new BrewController();

        [TestMethod]
        public void BrewControllerTestGetsAllBrews()
        {
            var fakeDb = new FakeDbContext();
            fakeDb.Brews = new FakeDbSet<Brew>();

            var brew = new Brew
            {
                ID = 1,
                UserId = "1",
                Name = "Foo",
                Type = "Bar",
                BrewDate = DateTime.Now,
                Secondaried = DateTime.Now,
                Bottled = DateTime.Now
            };

            fakeDb.Brews.Add(brew);

        }
    }
}
