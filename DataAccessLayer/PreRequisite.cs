using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class PreRequisite
    {
        public int PreRequisiteID { get; set; }
        public string Description { get; set; }

        public virtual ICollection<TrainingSubjectPreRequisite> TrainingSubjectPreRequisites { get; set; }        
    }
}
