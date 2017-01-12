using System.Linq;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetUserGroupDemo.APIControllers;
using NetUserGroupDemo.Models;
using NetUserGroupDemo.Repository;

namespace UnitTests
{
    [TestClass]
    public class WidgetsApiControllerTests
    {
        [TestMethod]
        public void Widgets_ReturnsTrue_When()
        {
            // Arrange
            WidgetsController controller = new WidgetsController(new DAL(new Logger<DAL>(new LoggerFactory())), new Logger<WidgetsController>(new LoggerFactory()));
            var expected = new Widget() { Id = 1, Name = "Widget 1", Price = 99.99m };

            // Act
            var actual = controller.Get().First();

            // Assert
            Assert.AreEqual(expected.Id, actual.Id);
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Price, actual.Price);
        }
    }
}
