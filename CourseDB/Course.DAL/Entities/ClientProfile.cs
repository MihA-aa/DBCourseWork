using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Course.DAL.Entities
{
    public class ClientProfile
    {
        [Key]
        [ForeignKey("ApplicationUser")]
        public string Id { get; set; }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int? PostId { get; set; }
        public virtual Post Post { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Discipline> Disciplines { get; set; }
        public ClientProfile()
        {
            Courses = new List<Course>();
            Disciplines = new List<Discipline>();
        }
    }
}
