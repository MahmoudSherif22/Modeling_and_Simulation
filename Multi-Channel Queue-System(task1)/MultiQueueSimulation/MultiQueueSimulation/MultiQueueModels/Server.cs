using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class Server
    {
        public Server()
        {
            this.TimeDistribution = new List<TimeDistribution>();
            this.FinishTime = 0; // 0 free
            this.Utilization = 0; //to start server with equal utilization
            this.TotalWorkingTime = 0;
            this.CustomersCount = 0;
            Simulation_Time_work = new Dictionary<int, int>();
        }
        public void Performance(decimal End_Time)
        {
            decimal Idle_Time = End_Time - (decimal)TotalWorkingTime;
            IdleProbability = Idle_Time / End_Time;
            AverageServiceTime = CustomersCount != 0? (decimal)TotalWorkingTime / (decimal)CustomersCount:0; //In rare case server didn't actually Work
            Utilization = (decimal)TotalWorkingTime / End_Time;
        }
        public int CustomersCount { get; set; } //added
        public Dictionary<int,int> Simulation_Time_work { get; set; } //added
        public int ID { get; set; }
        public decimal IdleProbability { get; set; }
        public decimal AverageServiceTime { get; set; }
        public decimal Utilization { get; set; }
        
        public List<TimeDistribution> TimeDistribution;

        //optional if needed use them
        public int FinishTime { get; set; }
        public int TotalWorkingTime { get; set; }
    }
}
