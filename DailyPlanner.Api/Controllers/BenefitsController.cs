using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyPlanner.Api.Controllers
{
    [Route("api/plans")]
    public class BenefitsController : Controller
    {
        [HttpGet("{planId}/benefits")]
        public IActionResult GetBenefits(int planId)
        {
            var plan = PlansDataStore.Current.Plans.FirstOrDefault(c => c.Id == planId);
            if (plan == null)
            {
                return NotFound();
            }

            return Ok(plan.Benefits);
        }
    }
}
