using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DailyPlanner.Api.Entities;

namespace DailyPlanner.Api.Repositories
{
    public class DailyPlannerRepository : IDailyPlannerRepository
    {
        private DailyPlannerContext _plannerContext;

        public DailyPlannerRepository(DailyPlannerContext plannerContext)
        {
            _plannerContext = plannerContext;
        }

        public IEnumerable<Benefit> Benefits(int planId)
        {
            return _plannerContext.Benefit.Where(c => c.PlanId == planId).ToList();
        }

        public Plan GetPlan(int planId)
        {
            return _plannerContext.Plans.Where(c => c.Id == planId).FirstOrDefault();
        }

        public IEnumerable<Plan> GetPlans()
        {
            return _plannerContext.Plans.OrderBy(c => c.Name).ToList();
        }
    }
}
