using Microsoft.AspNetCore.Mvc;

namespace YarpSamples.ReverseProxy.Controllers
{
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        [Route("/api/health")]
        public IActionResult CheckHealth()
        {
            return Ok();
        }
    }
}