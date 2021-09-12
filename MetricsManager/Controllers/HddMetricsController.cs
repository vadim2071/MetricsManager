using Microsoft.AspNetCore.Mvc;


namespace MetricsManager.Controllers
{
    [Route("api/metrics/hdd/left/[controller]")]
    [ApiController]
    public class HddMetricsController : ControllerBase
    {
        [HttpGet("agent/{agentId}")]
        public IActionResult GetMetricsFromAgent([FromRoute] int agentId)
        {
            return Ok();
        }
    }
}
