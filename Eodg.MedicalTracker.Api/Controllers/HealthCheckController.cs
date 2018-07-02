using Microsoft.AspNetCore.Mvc;

namespace Eodg.MedicalTracker.Api.Controllers
{
    public class HealthCheckController : BaseApiController
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Version = 0.1 });
        }
    }
}