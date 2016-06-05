using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DataAccessLayer
{
    /// <summary>
    /// Examples of Training Subject
    /// 1. Web Development using ASP.NET
    /// 2. Design Patterns - Part 1
    /// 3. Agile Developer Training
    /// </summary>
    public class TrainingSubject
    {
        public int TrainingSubjectID { get; set; }
        public string SubjectName { get; set; }
        public int TrainingSubjectCategoryID { get; set; }

        public virtual ICollection<TrainingSubjectPreRequisite> TrainingSubjectPreRequisites { get; set; }
        public virtual ICollection<TrainingSubjectSyllabus> TrainingSubjectSyllabuses { get; set; }
        public virtual TrainingSubjectCategory TrainingSubjectCategory { get; set; }
        public virtual ICollection<TrainingCourse> TrainingCourses { get; set; }
    }
}