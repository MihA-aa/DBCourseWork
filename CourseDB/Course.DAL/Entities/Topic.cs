using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.DAL.Entities
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal PeriodicityOfDemand { get; set; }
        public decimal AverageComplexity { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public Topic()
        {
            Tasks = new List<Task>();
        }
    }
}
