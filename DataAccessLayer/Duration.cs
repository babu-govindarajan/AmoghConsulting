using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Duration
    {
        public int DurationID { get; set; }
        public string DayTime { get; set; }

        public virtual ICollection<TrainingCourseDuration> TrainingCourseDurations { get; set; }
    }
}
