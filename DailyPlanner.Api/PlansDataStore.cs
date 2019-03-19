using DailyPlanner.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyPlanner.Api
{

    public class PlansDataStore
    {
        public static PlansDataStore Current { get; } = new PlansDataStore();

        public List<PlanDto> Plans { get; set; }

        public PlansDataStore()
        {
            Plans = new List<PlanDto>()
            {
                new PlanDto()
                {
                    Id = 1,
                    Name = "Fiona's Monday plan",
                    SelectedDate = "Monday",
                    Benefits = new List<BenefitsScoreDto>()
                    {
                        new BenefitsScoreDto()
                        {
                            Id = 1,
                            Name = "Heart",
                            Description = "Good for blood tp pump around the body and brain"
                        },
                        new BenefitsScoreDto()
                        {
                            Id = 1,
                            Name = "Mind",
                            Description = "Helps with anxiety"
                        }
                    }
                },
                new PlanDto()
                {
                    Id = 2,
                    Name = "Fiona's Tuesday plan",
                    SelectedDate = "Tuesday",
                    Benefits = new List<BenefitsScoreDto>()
                    {
                        new BenefitsScoreDto()
                        {
                            Id = 1,
                            Name = "Heart",
                            Description = "Good for blood tp pump around the body and brain"
                        }
                    }
                },
                new PlanDto()
                {
                    Id = 3,
                    Name = "Fiona's Wednesday plan",
                    SelectedDate = "Wednesday",
                    Benefits = new List<BenefitsScoreDto>()
                    {
                        new BenefitsScoreDto()
                        {
                            Id = 1,
                            Name = "Heart",
                            Description = "Good for blood tp pump around the body and brain"
                        },
                        new BenefitsScoreDto()
                        {
                            Id = 1,
                            Name = "Mind",
                            Description = "Helps with anxiety"
                        },
                        new BenefitsScoreDto()
                        {
                            Id = 1,
                            Name = "Weight",
                            Description = "Helps with your weight"
                        }
                    }
                }
            };  
        }
    }
}
