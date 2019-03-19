using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyPlanner.Api.Models
{
    public class PlanWithoutBenefitsDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SelectedDate { get; set; }
    }
}
