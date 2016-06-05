using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TrainingSubjectSyllabus
    {
        public int TrainingSubjectSyllabusID { get; set; }
        public int TrainingSubjectID { get; set; }
        public int SyllabusID { get; set; }

        public virtual TrainingSubject TrainingSubject { get; set; }
        public virtual Syllabus Syllabus { get; set; }
    }
}
