using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TrainingCourseDuration
    {
        public int TrainingCourseDurationId { get; set; }
        public int TrainingCourseId { get; set; }
        public int DurationID { get; set; }

        public virtual TrainingCourse TrainingCourse { get; set;}
        public virtual Duration Duration { get; set; }
    }
}
