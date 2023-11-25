using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class SimulationSystem
    {
        public SimulationSystem()
        {
            this.Servers = new List<Server>();
            this.InterarrivalDistribution = new List<TimeDistribution>();
            this.PerformanceMeasures = new PerformanceMeasures();
            this.SimulationTable = new List<SimulationCase>();
        }

        public void Inputs(String[] Modeling_file)
        {
            NumberOfServers = Int16.Parse(Modeling_file[1]);
            StoppingNumber = Int16.Parse(Modeling_file[4]);
            StoppingCriteria = Int16.Parse(Modeling_file[7]) == 1 ? Enums.StoppingCriteria.NumberOfCustomers : Enums.StoppingCriteria.SimulationEndTime;
            SelectionMethod = Int16.Parse(Modeling_file[10]) == 1 ? Enums.SelectionMethod.HighestPriority : Int16.Parse(Modeling_file[10]) == 2 ? Enums.SelectionMethod.Random : Enums.SelectionMethod.LeastUtilization;

            // from line 13 iterate then from last index add 2 then loop then add 2 then loop
            int i = 13;
            List<TimeDistribution> InterarrivalDistribution_entry = new List<TimeDistribution>();
            decimal last_one = 0;
            while (Modeling_file[i] != null && Modeling_file[i] != "")
            {
                char[] separators = new char[] { ' ', ',' };
                string[] subs = Modeling_file[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                TimeDistribution time_entry = new TimeDistribution();
                time_entry.Time = Int16.Parse(subs[0]);
                time_entry.Probability = decimal.Parse(subs[1]);
                time_entry.Calculation(last_one);
                InterarrivalDistribution_entry.Add(time_entry);
                i++;
                last_one = time_entry.CummProbability;
                Console.WriteLine(i);
            }
            InterarrivalDistribution = InterarrivalDistribution_entry;
            i += 2;
            List<Server> Servers_entry = new List<Server>();
            for (int n_servers = 0; n_servers < NumberOfServers; n_servers++)
            {
                Server s = new Server();
                last_one = 0;
                s.ID = n_servers + 1;
                while (Modeling_file[i] != null && Modeling_file[i] != "")
                {
                    char[] separators = new char[] { ' ', ',' };
                    string[] subs = Modeling_file[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    TimeDistribution time_entry = new TimeDistribution();
                    time_entry.Time = Int16.Parse(subs[0]);
                    time_entry.Probability = decimal.Parse(subs[1]);
                    time_entry.Calculation(last_one);
                    s.TimeDistribution.Add(time_entry);
                    last_one = time_entry.CummProbability;
                    i++;
                    if (i == Modeling_file.Length)
                        break;
                }
                Servers_entry.Add(s);
                i += 2;
            }
            Servers = Servers_entry;
        }
        public void Simulation_Run()
        {
            int Arrival_Time = 0; //Used for past customer save time
            int Customers_ID = 1;
            List<Server> Sorted_References = new List<Server>();
            Random rand = new Random();
            while (true) //Simulation Run by SimulationCase on customer
            {
                SimulationCase s_case = new SimulationCase();
                s_case.CustomerNumber = Customers_ID++;

                s_case.RandomInterArrival = rand.Next(1, 101);
                s_case.RandomService = rand.Next(1, 101);
                // Calculate customer arrival time
                foreach (TimeDistribution d in InterarrivalDistribution)
                {
                    if (s_case.RandomInterArrival >= d.MinRange && s_case.RandomInterArrival <= d.MaxRange)
                    {
                        s_case.InterArrival = d.Time;
                        break;
                    }
                }
                //Add case for first customer: 
                if(s_case.CustomerNumber != 1)
                    Arrival_Time = Arrival_Time + s_case.InterArrival;

                s_case.ArrivalTime = Arrival_Time;
                //Loop Breaker:
                if ((int)StoppingCriteria == 2 && Arrival_Time >= StoppingNumber)
                    break;
                else if (s_case.CustomerNumber > StoppingNumber)
                    break;

                //Sort by not Busy Then Selection Method
                switch ((int)SelectionMethod)
                {
                    case 1: //HighestPriority: Least Service Time
                        Sorted_References = Servers.OrderBy(server => server.ID).ToList();//TimeDistribution[server.TimeDistribution.Count - 1].Time);
                        break;
                    case 2: //Random: First Idle First Take == No more sorting
                        Sorted_References = Servers.OrderBy(server => server.FinishTime).ToList(); //FinishTime is 0 is free, free will be ordered first
                        break;
                    case 3: //LeastUtilization: Calculate Performance and sort on it
                        Sorted_References = Servers.OrderBy(server => server.Utilization).ToList();
                        break;
                    default:
                        break;
                }
                // check arrival time < Finish Time in loop:
                int index_free_server = -1;
                for (int i = 0; i < Servers.Count; i++)
                {
                    if(Sorted_References[i].FinishTime <= s_case.ArrivalTime)
                    {
                        index_free_server = i;
                        //In Server work
                        s_case.StartTime = s_case.ArrivalTime;
                        s_case.TimeInQueue = 0; //Since Entered without needing to get to else
                        break;
                    } 
                }
                if (index_free_server == -1)
                {
                    switch ((int)SelectionMethod)
                    {
                        case 1: //HighestPriority: Least Service Time
                            Sorted_References = Servers.OrderBy(server => server.FinishTime).ThenBy(server => server.ID).ToList(); //TimeDistribution[server.TimeDistribution.Count - 1].Time);
                            break;
                        case 2: //Random: First Idle First Take == No more sorting
                            Sorted_References = Servers.OrderBy(server => server.FinishTime).ToList(); //FinishTime is 0 is free, free will be ordered first
                            break;
                        case 3: //LeastUtilization: Calculate Performance and sort on it
                            Sorted_References = Servers.OrderBy(server => server.FinishTime).ThenBy(server => server.Utilization).ToList();
                            break;
                        default:
                            break;
                    }
                    index_free_server = 0;
                    s_case.TimeInQueue = Sorted_References[index_free_server].FinishTime - s_case.ArrivalTime; //First server to finish
                    s_case.StartTime = s_case.ArrivalTime + s_case.TimeInQueue;
                    PerformanceMeasures.Total_Customers_Queued++;
                    PerformanceMeasures.Total_Queue_Time += s_case.TimeInQueue;
                }
                //First one After ordered should be free or first to free anyway
                foreach (TimeDistribution d in Sorted_References[index_free_server].TimeDistribution)
                {
                    if (s_case.RandomService >= d.MinRange && s_case.RandomService <= d.MaxRange)
                    {
                        s_case.ServiceTime = d.Time; //Service Time
                        break;
                    }
                }
                //if (Servers[index_free_server].FinishTime <= s_case.ArrivalTime)
               
                s_case.EndTime = s_case.StartTime + s_case.ServiceTime;
                Sorted_References[index_free_server].FinishTime = s_case.EndTime;
                Sorted_References[index_free_server].TotalWorkingTime += s_case.ServiceTime;
                Sorted_References[index_free_server].CustomersCount++;
                for (int i = s_case.StartTime;i < s_case.EndTime; i++)
                    Sorted_References[index_free_server].Simulation_Time_work[i] = 1;

                s_case.AssignedServer = Sorted_References[index_free_server];
                s_case.Server_ID = Sorted_References[index_free_server].ID;

                SimulationTable.Add(s_case);

                //Calculate any Server Work in Loop for utilization: Service Time //sort by end time for simulation total run time ?
                Sorted_References[index_free_server].Utilization = (decimal)Servers[Sorted_References[index_free_server].ID - 1].TotalWorkingTime / (decimal)Servers[Sorted_References[index_free_server].ID - 1].FinishTime;
            }
            Sorted_References = Servers.OrderBy(server => server.FinishTime).ToList();
            Simulation_End = Sorted_References[Servers.Count - 1].FinishTime;
            foreach(Server s in Servers)
            {
                s.Performance(Simulation_End);
            }

            //Caculate Queue Time in Cases depend on time
            
            for (int i = 0; i < SimulationTable.Count; i++)
            {
                int count = 0;
                if (SimulationTable[i].TimeInQueue > 0) //Got queue
                {
                    for(int time = SimulationTable[i].ArrivalTime; time < SimulationTable[i].StartTime; time++)
                    {
                        for (int j = i; j < SimulationTable.Count; j++)
                        {
                            if (SimulationTable[j].ArrivalTime == time)
                            {
                                count++;
                            }
                        }
                    }
                    PerformanceMeasures.MaxQueueLength = PerformanceMeasures.MaxQueueLength > count ? PerformanceMeasures.MaxQueueLength : count;
                }
            }
            PerformanceMeasures.Performance(SimulationTable[SimulationTable.Count - 1].CustomerNumber);
            //Servers_IDs.DataSource = Servers.Select(s => s.ID).Distinct().ToList();
        }
        public decimal Simulation_End { get; set; } //added
        ///////////// INPUTS ///////////// 
        public int NumberOfServers { get; set; }
        public int StoppingNumber { get; set; }
        public List<Server> Servers { get; set; }
        public List<TimeDistribution> InterarrivalDistribution { get; set; }
        public Enums.StoppingCriteria StoppingCriteria { get; set; }
        public Enums.SelectionMethod SelectionMethod { get; set; }

        ///////////// OUTPUTS /////////////
        public List<SimulationCase> SimulationTable { get; set; }
        public PerformanceMeasures PerformanceMeasures { get; set; }

    }
}
