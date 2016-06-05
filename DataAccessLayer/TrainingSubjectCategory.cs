using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    /// <summary>
    /// You can categorize Training Subject as:
    /// 1. Software Development Engineer (SDE) Training
    /// 2. Software Development Engineer Test (SDET) Training
    /// 3. Mobile Application Development Training
    /// 4. Database Developer Training
    /// </summary>
    public class TrainingSubjectCategory
    {
        public int TrainingSubjectCategoryID { get; set; }
        public string Description { get; set; }
        public int TrainingCategoryID { get; set; }

        public virtual TrainingCategory TrainingCategory { get; set; }
    }
}
