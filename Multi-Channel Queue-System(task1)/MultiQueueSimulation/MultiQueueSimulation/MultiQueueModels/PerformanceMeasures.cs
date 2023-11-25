using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class PerformanceMeasures
    {
        public PerformanceMeasures()
        {
            MaxQueueLength = 0;
            Total_Customers_Queued = 0;
            Total_Queue_Time = 0;
        }
        public void Performance(int Number_Customers)
        {
            AverageWaitingTime = Total_Queue_Time / (decimal)Number_Customers;
            WaitingProbability = Total_Customers_Queued / (decimal)Number_Customers;
        }
        public decimal Total_Queue_Time { get; set; } //added
        public decimal Total_Customers_Queued { get; set; } //added
        public decimal AverageWaitingTime { get; set; }
        public int MaxQueueLength { get; set; }
        public decimal WaitingProbability { get; set; }
    }
}
