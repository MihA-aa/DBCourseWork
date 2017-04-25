using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.DAL.Entities
{
    public class Rating
    {
        public int Id { get; set; }
        public int ActualTime { get; set; }
        public decimal ActualComplexity { get; set; }
        public int? TaskId { get; set; }
        public int? ClientProfileId { get; set; }
        public virtual Task Task { get; set; }
        public virtual ClientProfile ClientProfile { get; set; }
    }
}
