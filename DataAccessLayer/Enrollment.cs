using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Enrollment
    {
        public int EnrollmentId { get; set; }
        public int TrainingCourseId { get; set; }
        public int StudentId { get; set; }
        public EnrollmentStage CurrentEnrollmentStage { get; set; }

        public virtual TrainingCourse TrainingCourse { get; set; }
        public virtual Student Student { get; set; }
    }
}
