using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.DAL.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DisciplineId { get; set; }
        public virtual Discipline Discipline { get; set; }
        public ICollection<Topic> Topics { get; set; }
        public ICollection<ClientProfile> Students { get; set; }
        public Course()
        {
            Students = new List<ClientProfile>();
            Topics = new List<Topic>();
        }
    }
}
