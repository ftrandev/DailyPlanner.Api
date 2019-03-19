using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DailyPlanner.Api.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DailyPlanner.Api.Controllers
{

    public class DummyController : ControllerBase
    {
        private DailyPlannerContext _ctx;

        public DummyController(DailyPlannerContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet]
        [Route("api/testdatabase")]
        public IActionResult TestDatabase()
        {
            return Ok();
        }
    }
}