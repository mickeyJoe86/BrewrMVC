using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BrewrMVC.Controllers;

namespace BrewrMVC.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        HomeController _homeController = new HomeController();
        [TestMethod]
        public void AboutActionReturnsAboutView()
        {
            
            var result = _homeController.About() as ViewResult;
            Assert.AreEqual("About", result.ViewName);
        }

        [TestMethod]
        public void ContactActionReturnsContactView()
        {            
            var result = _homeController.Contact() as ViewResult;
            Assert.AreEqual("Contact", result.ViewName);
        }
    }
}
