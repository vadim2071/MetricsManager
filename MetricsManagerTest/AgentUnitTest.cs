using System;
using Xunit;
using MetricsManager.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace MetricsManagerTest
{
    public class AgentUnitTest
    {

        private AgentController controller;

        public AgentUnitTest()
        {
            controller = new AgentController();
        }

        [Fact]
        public void RegisterAgent()
        {
            //Arrange

            var agentInfo = new AgentCreateDto(1, new Uri("https://kjnsdjkfs.com/"));

            //Act
            var result = controller.RegisterAgent(agentInfo);

            //Assert

            Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
