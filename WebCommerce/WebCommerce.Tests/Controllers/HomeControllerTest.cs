using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebCommerce;
using WebCommerce.Controllers;
using Repository;
using Repository.Infrastructure;
using System.Diagnostics;

namespace WebCommerce.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            //IDemoRepository demoRepository = new DemoRepository(new DbFactory());
            //// Arrange
            //HomeController controller = new HomeController(demoRepository);
            //// Act
            //ViewResult result = controller.Index() as ViewResult;
            //// Assert
            //Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
           // HomeController controller = new HomeController();

            // Act
          //  ViewResult result = controller.About() as ViewResult;

            // Assert
          //  Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
       //     HomeController controller = new HomeController();

            // Act
         //   ViewResult result = controller.Contact() as ViewResult;

            // Assert
         //   Assert.IsNotNull(result);
        }
    }
}
