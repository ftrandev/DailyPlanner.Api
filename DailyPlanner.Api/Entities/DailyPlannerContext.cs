using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyPlanner.Api.Entities
{
    public class DailyPlannerContext: DbContext
    {
        public DailyPlannerContext(DbContextOptions<DailyPlannerContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<Benefit> Benefit { get; set; }
    }
}
