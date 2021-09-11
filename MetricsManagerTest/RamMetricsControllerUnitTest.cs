using System;
using Xunit;
using MetricsManager.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace MetricsManagerTest
{
    public class RamMetricsControllerUnitTest
    {
        private RamMetricsController controller;

        public RamMetricsControllerUnitTest()
        {
            controller = new RamMetricsController();
        }

        [Fact]
        public void GetMetricsFromAgent()
        {
            //Arrange
            var agentId = 1;
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            //Act
            var result = controller.GetMetricsFromAgent(agentId, fromTime, toTime);

            //Assert

            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}