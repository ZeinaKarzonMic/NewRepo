using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Controllers;
using Microsoft.AspNetCore.Mvc;
namespace ContinuousWeb.Tests
{
    [TestClass]
    public class HomeControllerTests
    {        
        [TestMethod]
        public void AboutPageTest()
        {
            var homeController = new HomeController();
            
            var result = homeController.About();
        }
    }
}