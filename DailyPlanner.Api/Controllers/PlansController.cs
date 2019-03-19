using AutoMapper;
using DailyPlanner.Api.Models;
using DailyPlanner.Api.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyPlanner.Api.Controllers
{
    [Route("api/[controller]")]

    public class PlansController : Controller
    {
        private IDailyPlannerRepository _dailyPlannerRepository;
        
        public PlansController(IDailyPlannerRepository dailyPlannerRepository)
        {
            _dailyPlannerRepository = dailyPlannerRepository;
        }

        [HttpGet()]
        public IActionResult GetPlans()
        {
            // return Ok(PlansDataStore.Current.Plans);
            var planEntities = _dailyPlannerRepository.GetPlans();
            var results = Mapper.Map<IEnumerable<PlanWithoutBenefitsDto>>(planEntities);
            return Ok(results);
        }

        [HttpGet("{id}")]
        public IActionResult GetPlan(int id)
        {
            var planToReturn = PlansDataStore.Current.Plans.FirstOrDefault(c => c.Id == id);
            if (planToReturn == null)
            {
                return NotFound();
            }

            return Ok(planToReturn);
        }
    }
}
