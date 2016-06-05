using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string EducationalQualification { get; set; }
        public string ItExperience { get; set; }
        public string HowKnowAboutUs { get; set; }
        public string Message { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
