using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Eodg.MedicalTracker.Api.Controllers
{
    public class TestMembersController : BaseApiController
    {
        public IActionResult Get()
        {
            return Ok();
        }
    }
}