using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class PerformanceMeasures
    {
        public PerformanceMeasures()
        {
            TotalSalesProfit = 0;
            TotalCost = 0;
            TotalLostProfit = 0;
            TotalScrapProfit = 0;
            TotalNetProfit = 0;
            DaysWithMoreDemand = 0;
            DaysWithUnsoldPapers = 0;
        }
        public decimal TotalSalesProfit { get; set; }
        public decimal TotalCost { get; set; }
        public decimal TotalLostProfit { get; set; }
        public decimal TotalScrapProfit { get; set; }
        public decimal TotalNetProfit { get; set; }
        public int DaysWithMoreDemand { get; set; }
        public int DaysWithUnsoldPapers { get; set; }
    }
}
