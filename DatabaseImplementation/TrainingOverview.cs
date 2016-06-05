using System;
using System.Collections.Generic;
using System.Linq;

namespace DatabaseImplementation
{
    public class TrainingOverview : IEquatable<TrainingOverview>, IComparable<TrainingOverview>
    {
        public int TrainingCategoryID { get; set; }
        public string TrainingCategoryDescription { get; set; }
        public int TrainingSubjectCategoryID { get; set; }
        public string TrainingSubjectCategoryDescription { get; set; }

        public bool Equals(TrainingOverview other)
        {
            if (other == null)
                return false;
            else
                return Equals(other);
        }

        public int CompareTo(TrainingOverview other)
        {
            if (other == null)
                return 1;
            else
                return this.TrainingCategoryID.CompareTo(other.TrainingCategoryID);
        }
    }    
}