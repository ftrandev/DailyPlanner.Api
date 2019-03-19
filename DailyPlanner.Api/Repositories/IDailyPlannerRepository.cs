using DailyPlanner.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyPlanner.Api.Repositories
{
    public interface IDailyPlannerRepository
    {
        IEnumerable<Plan> GetPlans();
        Plan GetPlan(int planId);
        IEnumerable<Benefit> Benefits(int planId);
    }
}
