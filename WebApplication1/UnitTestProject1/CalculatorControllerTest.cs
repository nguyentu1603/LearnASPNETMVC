using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Controllers;
using System.Web.Mvc;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculatorControllerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            CalculatorController controller = new CalculatorController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
         [TestMethod]
        public void TestAuthor()
        {
            var controller = new CalculatorController();
            var result = controller.ShowAuthor();
            Assert.AreEqual("Nguyen Anh Tu", result);
        }
    }
}
