using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewspaperSellerModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            DayTypeDistributions = new List<DayTypeDistribution>();
            DemandDistributions = new List<DemandDistribution>();
            SimulationTable = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();
        }
        public void Inputs(String[] Modeling_file)
        {
            NumOfNewspapers = Int16.Parse(Modeling_file[1]);
            NumOfRecords = Int16.Parse(Modeling_file[4]);
            PurchasePrice = Decimal.Parse(Modeling_file[7]);
            ScrapPrice = Decimal.Parse(Modeling_file[10]);
            SellingPrice = Decimal.Parse(Modeling_file[13]);

            char[] separators = new char[] { ' ', ',' };
            string[] subs = Modeling_file[16].Split(separators, StringSplitOptions.RemoveEmptyEntries);
            decimal last_one = 0;
            DayTypeDistribution temp_DTD = new DayTypeDistribution();
            int i2nd = 0;
            for(i2nd = 0; i2nd < 3; i2nd++)
            {
                temp_DTD.DayType = (Enums.DayType)i2nd;
                temp_DTD.Probability = decimal.Parse(subs[i2nd]);
                temp_DTD.Calculation(last_one);
                last_one = temp_DTD.CummProbability;
                DayTypeDistributions.Add(temp_DTD);
                temp_DTD = new DayTypeDistribution();
            }
            int i = 19;
            decimal[] last_ones = { 0, 0, 0 };
            while (Modeling_file[i] != null && Modeling_file[i] != "")
            {
                DemandDistribution temp_DD = new DemandDistribution(); 
                separators = new char[] { ' ', ',' };
                subs = Modeling_file[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                temp_DD.Demand = int.Parse(subs[0]);
                
                for (i2nd = 1; i2nd < 4; i2nd++)
                {
                    temp_DTD.DayType = (Enums.DayType)i2nd-1;
                    temp_DTD.Probability = decimal.Parse(subs[i2nd]);
                    temp_DTD.Calculation(last_ones[i2nd-1]);
                    last_ones[i2nd-1] = temp_DTD.CummProbability;
                    temp_DD.DayTypeDistributions.Add(temp_DTD);
                    temp_DTD = new DayTypeDistribution();
                }
                DemandDistributions.Add(temp_DD);
                i++;
                if (i == Modeling_file.Length)
                    break;
            }
            UnitProfit = SellingPrice - PurchasePrice;
        }
        public void Simulation_Run()
        { 
            Random rand = new Random();
            for(int day = 1; day <= NumOfRecords; day++)
            {
                SimulationCase s_case = new SimulationCase();
                s_case.DayNo = day;
                s_case.RandomNewsDayType = rand.Next(1,101);
                s_case.RandomDemand = rand.Next(1, 101);
                // Calculate Day Type
                foreach (DayTypeDistribution d in DayTypeDistributions)
                {
                    if (s_case.RandomNewsDayType >= d.MinRange && s_case.RandomNewsDayType <= d.MaxRange)
                    {
                        s_case.NewsDayType = d.DayType;
                        break;
                    }
                }
                int index_day_type = (int)s_case.NewsDayType;
                foreach (DemandDistribution d in DemandDistributions)
                {
                    if (s_case.RandomDemand >= d.DayTypeDistributions[index_day_type].MinRange && s_case.RandomDemand <= d.DayTypeDistributions[index_day_type].MaxRange)
                    {
                        s_case.Demand = d.Demand;
                        break;
                    }
                }
                s_case.DailyCost = NumOfNewspapers * PurchasePrice;
                if (s_case.Demand > NumOfNewspapers)
                {
                    s_case.SalesProfit = NumOfNewspapers * SellingPrice;
                    s_case.LostProfit = (s_case.Demand - NumOfNewspapers) * UnitProfit;
                    PerformanceMeasures.TotalLostProfit += s_case.LostProfit;
                    PerformanceMeasures.DaysWithMoreDemand++;
                }
                else if(s_case.Demand < NumOfNewspapers)
                {
                    s_case.SalesProfit = s_case.Demand * SellingPrice;
                    s_case.ScrapProfit = (NumOfNewspapers - s_case.Demand) * ScrapPrice;
                    PerformanceMeasures.TotalScrapProfit += s_case.ScrapProfit;
                    PerformanceMeasures.DaysWithUnsoldPapers++;
                }
                else
                    s_case.SalesProfit = s_case.Demand * SellingPrice;

                s_case.DailyNetProfit = s_case.SalesProfit - s_case.DailyCost - s_case.LostProfit + s_case.ScrapProfit;
                
                PerformanceMeasures.TotalSalesProfit += s_case.SalesProfit;
                PerformanceMeasures.TotalCost += s_case.DailyCost;
                PerformanceMeasures.TotalNetProfit += s_case.DailyNetProfit;
                SimulationTable.Add(s_case);
            }
        }
        ///////////// INPUTS /////////////
        public int NumOfNewspapers { get; set; }
        public int NumOfRecords { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal ScrapPrice { get; set; }
        public decimal UnitProfit { get; set; }
        public List<DayTypeDistribution> DayTypeDistributions { get; set; }
        public List<DemandDistribution> DemandDistributions { get; set; }

        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }
    }
}
