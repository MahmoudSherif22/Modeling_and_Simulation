using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            DemandDistribution = new List<Distribution>();
            LeadDaysDistribution = new List<Distribution>();
            SimulationCases = new List<SimulationCase>();
            PerformanceMeasures = new PerformanceMeasures();
        }


        public void Inputs(String[] Modeling_file)
        {
            OrderUpTo = Int16.Parse(Modeling_file[1]);
            ReviewPeriod = Int16.Parse(Modeling_file[4]);
            StartInventoryQuantity = Int16.Parse(Modeling_file[7]);
            StartLeadDays = (Int16.Parse(Modeling_file[10]))-1;
            StartOrderQuantity = Int16.Parse(Modeling_file[13]);
            NumberOfDays = Int16.Parse(Modeling_file[16]);

            char[] separators;
            string[] subs;
            decimal last_one = 0;
            Distribution temp_DemanD = new Distribution();
            int i = 19;
            while(Modeling_file[i] != null && Modeling_file[i] != "")
            {
                separators = new char[] { ' ', ',' };
                subs = Modeling_file[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                temp_DemanD.Value = Int16.Parse(subs[0]);
                temp_DemanD.Probability = Decimal.Parse(subs[1]);
                temp_DemanD.CalculationDemand_Lead(last_one);
                last_one = temp_DemanD.CummProbability;
                DemandDistribution.Add(temp_DemanD);
                temp_DemanD = new Distribution();
                i++;
            }
            i += 2;
            last_one = 0;
            Distribution temp_LeadDayD = new Distribution();
            while (Modeling_file[i] != null && Modeling_file[i] != "")
            {
                separators = new char[] { ' ', ',' };
                subs = Modeling_file[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                temp_LeadDayD.Value = Int16.Parse(subs[0]);
                temp_LeadDayD.Probability = Decimal.Parse(subs[1]);
                temp_LeadDayD.CalculationDemand_Lead(last_one);
                last_one = temp_LeadDayD.CummProbability;
                LeadDaysDistribution.Add(temp_LeadDayD);
                temp_LeadDayD = new Distribution();
                i++;
                if (i == Modeling_file.Length)
                    break;
            }

        }

        public void Simulation_Run()
        {
            Random rand = new Random();
            int day_Cycle_counter = 0;
            int Cycle_counter = 1;
            int order_quantity = StartOrderQuantity;
            
            for (int day = 1; day <= NumberOfDays; day++)
            {
                SimulationCase s_case = new SimulationCase();
                s_case.ShortageQuantity = 0;
                s_case.Day = day;
                day_Cycle_counter++;
                if (day_Cycle_counter > ReviewPeriod)
                {
                    day_Cycle_counter = 1;
                    Cycle_counter++;
                }
                s_case.Cycle = Cycle_counter;
                s_case.DayWithinCycle = day_Cycle_counter;
                if (day == 1)
                {
                    s_case.BeginningInventory = StartInventoryQuantity;
                    s_case.DaysUntilOrder = StartLeadDays;
                }
                else {
                    s_case.BeginningInventory = SimulationCases[day - 2].EndingInventory; 
                    if(SimulationCases[day-2].DaysUntilOrder > 0)
                    {
                        s_case.DaysUntilOrder = (SimulationCases[day - 2].DaysUntilOrder)-1;
                    }
                    else if(SimulationCases[day - 2].DaysUntilOrder == 0)
                    {
                        if (SimulationCases[day - 2].ShortageQuantity > order_quantity)
                        {
                            s_case.ShortageQuantity = SimulationCases[day - 2].ShortageQuantity - order_quantity;
                            s_case.BeginningInventory = 0;
                        }
                        else
                        {
                            s_case.BeginningInventory += order_quantity;
                        }
                    }
                }

                s_case.RandomDemand = rand.Next(1, 101);
                // Calculate Demand
                foreach (Distribution d in DemandDistribution)
                {
                    if (s_case.RandomDemand >= d.MinRange && s_case.RandomDemand <= d.MaxRange)
                    {
                        s_case.Demand = d.Value;
                        break;
                    }
                }
                int Available; 
                if(day == 1)
                    Available=s_case.BeginningInventory - s_case.Demand;
                else
                    Available = s_case.BeginningInventory - (s_case.Demand+ SimulationCases[day - 2].ShortageQuantity);
                if (Available < 0)
                {
                    s_case.EndingInventory = 0;
                    s_case.ShortageQuantity = (Available * (-1));
               
                }
                else
                    s_case.EndingInventory = Available;
                if (day_Cycle_counter == ReviewPeriod) {
                    order_quantity = OrderUpTo - s_case.EndingInventory + s_case.ShortageQuantity;
                    s_case.OrderQuantity = order_quantity;
                    s_case.RandomLeadDays = rand.Next(1,101);
                    // Calculate LeadDays
                    foreach (Distribution d in LeadDaysDistribution)
                    {
                        if (s_case.RandomLeadDays >= d.MinRange && s_case.RandomLeadDays <= d.MaxRange)
                        {
                            if (day != 1)
                            {
                                s_case.LeadDays = d.Value;
                                s_case.DaysUntilOrder = d.Value;
                                break;
                            }
                        }
                    }
                }
                PerformanceMeasures.EndingInventoryAverage += s_case.EndingInventory;
                PerformanceMeasures.ShortageQuantityAverage += s_case.ShortageQuantity;
                SimulationCases.Add(s_case);
            }
            PerformanceMeasures.EndingInventoryAverage = PerformanceMeasures.EndingInventoryAverage / NumberOfDays;
            PerformanceMeasures.ShortageQuantityAverage = PerformanceMeasures.ShortageQuantityAverage / NumberOfDays;
        }
        ///////////// INPUTS /////////////

        public int OrderUpTo { get; set; }
        public int ReviewPeriod { get; set; }
        public int NumberOfDays { get; set; }
        public int StartInventoryQuantity { get; set; }
        public int StartLeadDays { get; set; }
        public int StartOrderQuantity { get; set; }
        public List<Distribution> DemandDistribution { get; set; }
        public List<Distribution> LeadDaysDistribution { get; set; }


        ///////////// OUTPUTS /////////////

        public List<SimulationCase> SimulationCases { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }

    }
}
