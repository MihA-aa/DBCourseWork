using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.DAL.Entities
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PlannedComplexity { get; set; }
        public decimal AverageComplexity { get; set; }
        public int PlannedTime { get; set; }
        public int AverageTime { get; set; }
        public decimal PeriodicityOfVisiting { get; set; }
        public decimal PeriodicityOfRequirement { get; set; }
        public string Answer { get; set; }
        public ICollection<Topic> Topics { get; set; }
        public Task()
        {
            Topics = new List<Topic>();
        }
    }
}
