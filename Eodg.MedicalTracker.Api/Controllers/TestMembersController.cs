using System.Collections.Generic;
using System.Linq;
using Eodg.MedicalTracker.Data;
using Eodg.MedicalTracker.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Eodg.MedicalTracker.Api.Controllers
{
    public class TestMembersController : BaseApiController
    {
        private MedicalTrackerContext _medicalTrackerContext;

        public TestMembersController(MedicalTrackerContext medicalTrackerContext)
        {
            _medicalTrackerContext = medicalTrackerContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_medicalTrackerContext.Members.ToList());
        }

        [HttpPost]
        public IActionResult Post(Member member)
        {
            _medicalTrackerContext.Members.Add(member);

            _medicalTrackerContext.SaveChanges();

            return Ok(member);
        }
    }
}