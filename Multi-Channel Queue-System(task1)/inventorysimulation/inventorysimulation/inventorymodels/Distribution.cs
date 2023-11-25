using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    public class Distribution
    {
        public void CalculationDemand_Lead(decimal last_one)
        {
            CummProbability = Probability + last_one;
            MinRange = (int)(last_one * 100) + 1;
            MaxRange = (int)(CummProbability * 100);
        }
       
        public int Value { get; set; }
        public decimal Probability { get; set; }
        public decimal CummProbability { get; set; }
        public int MinRange { get; set; }
        public int MaxRange { get; set; }
    }
}
