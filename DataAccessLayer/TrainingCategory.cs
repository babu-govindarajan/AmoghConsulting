using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    /// <summary>
    /// You can categorize the training as:
    /// 1. IT Training
    /// 2. Agile
    /// 3. Architecture
    /// </summary>
    public class TrainingCategory
    {
        public int TrainingCategoryID { get; set; }
        public string Description { get; set; }
    }
}
