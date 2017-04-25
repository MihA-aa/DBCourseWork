using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.DAL.Entities
{
    public class Discipline
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public ICollection<ClientProfile> Teachers { get; set; }
        public Discipline()
        {
            Teachers = new List<ClientProfile>();
            Courses = new List<Course>();
        }
    }
}
