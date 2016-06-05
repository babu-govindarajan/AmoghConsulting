using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccessLayer
{
    /// <summary>
    /// Instance of TrainingSubject offered for a particular time period and Location
    /// </summary>
    public class TrainingCourse
    {
        public int TrainingCourseID { get; set; }
        public int TrainingSubjectID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }

        public virtual TrainingSubject SubjectDetails { get; set; }
        public virtual ICollection<TrainingCourseDuration> TrainingCourseDurations { get; set; }
        
    }
}