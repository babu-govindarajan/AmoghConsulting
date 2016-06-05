using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TrainingContext : DbContext
    {
        public TrainingContext() : base("TrainingContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<TrainingSubjectCategory> TrainingSubjectCategories { get; set; }
        public DbSet<TrainingCategory> TrainingCategories { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<TrainingCourse> TrainingCourses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<TrainingCourseDuration> TrainingCourseDurations { get; set; }
        public DbSet<Duration> Durations { get; set; }
        public DbSet<TrainingSubject> TrainingSubjects { get; set; }
        public DbSet<TrainingSubjectSyllabus> TrainingSubjectSyllabuses { get; set; }        
        public DbSet<Syllabus> Syllabuses { get; set; }
        public DbSet<TrainingSubjectPreRequisite> TrainingSubjectPreRequisites { get; set; }
        public DbSet<PreRequisite> PreRequisites { get; set; }
        public DbSet<ContactUs> ContactUses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();            
        }
    }
}
