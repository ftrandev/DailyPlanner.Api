using DailyPlanner.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyPlanner.Api
{
    public static class DailyPlannerContextExtensions
    {
        public static void EnsureSeedDataForContext(this DailyPlannerContext context)
        {
            if (context.Plans.Any())
                return;

            // init seed data
            var plans = new List<Plan>()
            {
                new Plan()
                {
                    Name = "Breakfast",
                    SelectedDate = "",
                    Benefit = new List<Benefit>()
                    {
                        new Benefit()
                        {
                            Name = "Energy",
                            Description = "Boost to start the day"
                        }
                    }
                },
                new Plan()
                {
                    Name = "Exercise",
                    SelectedDate = "",
                    Benefit = new List<Benefit>()
                    {
                        new Benefit()
                        {
                            Name = "Fitness",
                            Description = "Promotes a stronger heart"
                        },
                        new Benefit()
                        {
                            Name = "Weight loss",
                            Description = "Loss weight "
                        }
                    }
                },
                new Plan()
                {
                    Name = "Read a book",
                    SelectedDate = "",
                    Benefit = new List<Benefit>()
                    {
                        new Benefit()
                        {
                            Name = "Relaxation",
                            Description = ""
                        },
                        new Benefit()
                        {
                            Name = "Knowledge",
                            Description = "Learn and self improve"
                        }
                    }
                }
            };

            context.Plans.AddRange(plans);
            context.SaveChanges();
        }
    }
}
