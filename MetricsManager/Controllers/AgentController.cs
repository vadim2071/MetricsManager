using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AgentController : ControllerBase
    {
        [HttpPost("register")]
        public IActionResult RegisterAgent([FromBody] AgentCreateDto agentInfo)
        {
            return Ok();
        }

        [HttpPut("enable/{agentId}")]
        public IActionResult EnableAgentById([FromRoute] int agentId)
        {
            return Ok();
        }

        [HttpPut("disable/{agentId}")]
        public IActionResult DisableAgentById([FromRoute] int agentId)
        {
            return Ok();
        }
    }

    public class AgentCreateDto
    {
        public int AgentId { get; set; }

        public Uri AgentAddress { get; set; }

        public AgentCreateDto(int _agentId, Uri _agentAdress)
        {
            AgentId = _agentId;
            AgentAddress = _agentAdress;
        }
    }
}
