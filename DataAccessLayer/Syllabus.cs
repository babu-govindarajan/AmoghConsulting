using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    /// <summary>
    /// 
    /// </summary>
    public class Syllabus
    {
        public int SyllabusID { get; set; }
        public string Description { get; set; }

        public virtual ICollection<TrainingSubjectSyllabus> TrainingSubjectSyllabuses { get; set; }        
    }
}
