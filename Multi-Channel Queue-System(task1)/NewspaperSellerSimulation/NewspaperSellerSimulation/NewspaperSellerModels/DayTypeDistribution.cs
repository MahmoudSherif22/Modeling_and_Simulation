using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class DayTypeDistribution
    {
        public void Calculation(decimal last_one)
        {
            CummProbability = Probability + last_one;
            MinRange = (int)(last_one * 100) + 1;
            MaxRange = (int)(CummProbability * 100);
        }
        public Enums.DayType DayType { get; set; }
        public decimal Probability { get; set; }
        public decimal CummProbability { get; set; }
        public int MinRange { get; set; }
        public int MaxRange { get; set; }
    }
}
