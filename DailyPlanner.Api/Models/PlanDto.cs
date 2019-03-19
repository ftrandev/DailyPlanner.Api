using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyPlanner.Api.Models
{
    public class PlanDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SelectedDate { get; set; }
        public int NumberOfBenefits
        {
            get
            {
                return Benefits.Count;
            }
        }
        public ICollection<BenefitsScoreDto> Benefits { get; set; }
        = new List<BenefitsScoreDto>();
    }
}
