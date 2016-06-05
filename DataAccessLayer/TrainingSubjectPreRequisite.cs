using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TrainingSubjectPreRequisite
    {
        public int TrainingSubjectPreRequisiteID { get; set; }
        public int TrainingSubjectID { get; set; }
        public int PreRequisiteID { get; set; }

        public virtual TrainingSubject TrainingSubject { get; set; }
        public virtual PreRequisite PreRequisite { get; set; }
    }
}
