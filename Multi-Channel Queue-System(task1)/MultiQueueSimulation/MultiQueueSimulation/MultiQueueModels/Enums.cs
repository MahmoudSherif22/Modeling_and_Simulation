using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiQueueModels
{
    public class Enums
    {
        public enum SelectionMethod
        {
            HighestPriority = 1, //Least Service Time
            Random = 2, // First Idle First Take
            LeastUtilization = 3 //Calculate Performance before use
        }

        public enum StoppingCriteria
        {
            NumberOfCustomers = 1,
            SimulationEndTime = 2
        }
    }
}
