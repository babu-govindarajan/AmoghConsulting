using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DataAccessLayer
{
    public class TrainingInitializer : CreateDatabaseIfNotExists<TrainingContext>
    {
        protected override void Seed(TrainingContext context)
        {
            var durations = new List<Duration>
            {
                new Duration {DurationID=1, DayTime="Saturday from 10:00AM to 12:00Noon"},
                new Duration {DurationID=2, DayTime="Saturday from 1:00PM to 3:00PM"},
                new Duration {DurationID=3,  DayTime="Sunday from 10:00AM to 12:00Noon"},
                new Duration {DurationID=4, DayTime="Monday from 6:00PM to 7:00PM"},
                new Duration {DurationID=5, DayTime="Tuesday from 6:00PM to 7:00PM"},
                new Duration {DurationID=6, DayTime="Wednesday from 6:00PM to 7:00PM"},
            };

            durations.ForEach(d => context.Durations.Add(d));
            context.SaveChanges();
            
            var syllabuses = new List<Syllabus>
            {
                //MVC
                new Syllabus {SyllabusID=1, Description="MVC Controller"},
                new Syllabus {SyllabusID=2, Description="MVC Routing"},
                new Syllabus {SyllabusID=3, Description="Razor View"},
                new Syllabus {SyllabusID=4, Description="OAuth Membership"},

                //SDET
                new Syllabus {SyllabusID=5, Description="Test Driven Development"},
                new Syllabus {SyllabusID=6, Description="Unit Testing"},
                new Syllabus {SyllabusID=7, Description="Dependency Injection"},
                new Syllabus {SyllabusID=8, Description="Building Testable Applications"},
                new Syllabus {SyllabusID=9, Description="Introduction to Visual Studio Test Manager"},

                //C#
                new Syllabus {SyllabusID=10, Description="C# Essentials"},
                new Syllabus {SyllabusID=11, Description="Debugging, Tracing, and Profiling"},
                new Syllabus {SyllabusID=12, Description="Parallel Processing and Concurrency"},

                //WCF
                new Syllabus {SyllabusID=13, Description="Basic WCF Programming"},
                new Syllabus {SyllabusID=14, Description="WCF Development Tools"},
                new Syllabus {SyllabusID=15, Description="WCF Endpoints"},
                new Syllabus {SyllabusID=16, Description="WCF Hosting"},

                //Security 
                new Syllabus {SyllabusID=17, Description="Security Concept"},
                new Syllabus {SyllabusID=18, Description="Introduction to Cryptography"},

                //Mobile Application
                new Syllabus {SyllabusID=19, Description="Introduction to Eclipse and AndroSyllabusID Developer Tools"},
                new Syllabus {SyllabusID=20, Description="Introduction to iOS SDK and Xcode"},
                new Syllabus {SyllabusID=21, Description="Introduction to Universal Windows app"},

                //Database Fundamentals
                new Syllabus {SyllabusID=22, Description="Core Database Concepts"},
                new Syllabus {SyllabusID=23, Description="Relational Concepts"},

                //SQL Server
                new Syllabus {SyllabusID=24, Description="Introduction to Microsoft SQL Server"},
                new Syllabus {SyllabusID=25, Description="Introduction to Microsoft SQL Server Database Developer Tools"},

                //LINQ
                new Syllabus {SyllabusID=26, Description="Introduction: LINQ to Relational Data"},

                //Oracle
                new Syllabus {SyllabusID=27, Description="Introduction to Oracle Database"},
                new Syllabus {SyllabusID=28, Description="Introduction to Oracle Database Developer Tools"},

                //Entity Framework
                new Syllabus {SyllabusID=29, Description="Introduction to Entity Framework"},
                new Syllabus {SyllabusID=30, Description="Entity Framework Code First"},
                new Syllabus {SyllabusID=31, Description="Entity Framework Profiler"},

                //Advanced C#
                new Syllabus {SyllabusID=32, Description="C#: Memory Management and Garbage Collection"},
                new Syllabus {SyllabusID=33, Description="C#: Dynamic Programming"},

                //Windows development
                new Syllabus {SyllabusID=34, Description="Introduction to Windows Services Application"},
                new Syllabus {SyllabusID=35, Description="Introduction to XAML"},  
                
                //Web Design
                new Syllabus {SyllabusID=36, Description="Introduction to CSS3"},  
                new Syllabus {SyllabusID=37, Description="Introduction to HTML5"},  
                new Syllabus {SyllabusID=38, Description="Introduction to Adaptive and Responsive Design"},  

                //RESTFul
                new Syllabus {SyllabusID=39, Description="Designing Resource-Oriented Services"},  
            };

            syllabuses.ForEach(s => context.Syllabuses.Add(s));
            context.SaveChanges();

            var preRequisites = new List<PreRequisite>
            {
                new PreRequisite {PreRequisiteID=1, Description="HTTP ptotocol, CSS and HTML" },
                new PreRequisite {PreRequisiteID=2, Description="C# Basics" },
                new PreRequisite {PreRequisiteID=3, Description="HTTP ptotocol, CSS and HTML" },
                new PreRequisite {PreRequisiteID=4, Description="Relational Database concepts" },                
            };

            preRequisites.ForEach(p => context.PreRequisites.Add(p));
            context.SaveChanges();

            var trainingCategories = new List<TrainingCategory>
            {
                new TrainingCategory { Description="IT Training", TrainingCategoryID=1 },
                new TrainingCategory {  Description="Management", TrainingCategoryID=2 },
                new TrainingCategory{ Description="Architecture", TrainingCategoryID=3 }
            };

            trainingCategories.ForEach(t => context.TrainingCategories.Add(t));
            context.SaveChanges();

            var trainingSubjectCategories = new List<TrainingSubjectCategory>
            {
                new TrainingSubjectCategory 
                {
                    Description="Software Developer Training", TrainingSubjectCategoryID=1, TrainingCategoryID=1
                },
                new TrainingSubjectCategory 
                {
                    Description="Mobile Application Development", TrainingSubjectCategoryID=2, TrainingCategoryID=1
                },
                new TrainingSubjectCategory{
                    Description="Software Design Engineer Test", TrainingSubjectCategoryID=3, TrainingCategoryID=1
                },
                new TrainingSubjectCategory { 
                    Description="Database Developer Training", TrainingSubjectCategoryID=4, TrainingCategoryID=1
                },
                new TrainingSubjectCategory { 
                    Description="Agile Training", TrainingSubjectCategoryID=5, TrainingCategoryID=2
                },
                new TrainingSubjectCategory { 
                    Description="Project Management Training", TrainingSubjectCategoryID=6, TrainingCategoryID=2
                },

                new TrainingSubjectCategory { 
                    Description="Technical Architecture", TrainingSubjectCategoryID=7, TrainingCategoryID=3
                },
                new TrainingSubjectCategory { 
                    Description="Enterprise Architecture", TrainingSubjectCategoryID=8, TrainingCategoryID=3
                },
            };
            trainingSubjectCategories.ForEach(t => context.TrainingSubjectCategories.Add(t));
            context.SaveChanges();

            var subjectDetails = new List<TrainingSubject>
            {
                new TrainingSubject 
                {
                    TrainingSubjectID=1, SubjectName="Web Development using ASP.NET MVC", TrainingSubjectCategoryID=1
                },
                new TrainingSubject
                {
                    TrainingSubjectID=2, SubjectName="Web and RESTFul Services development using WCF", TrainingSubjectCategoryID=1
                },
                new TrainingSubject
                {
                    TrainingSubjectID=3, SubjectName="Website Design", TrainingSubjectCategoryID=1
                },
                new TrainingSubject
                {
                    TrainingSubjectID=4, SubjectName="Advanced C# Programming", TrainingSubjectCategoryID=1
                },
                new TrainingSubject
                {
                    TrainingSubjectID=5, SubjectName="Desktop Application development using WPF", TrainingSubjectCategoryID=1
                },
                new TrainingSubject
                {
                    TrainingSubjectID=6, SubjectName="Windows Phone Development", TrainingSubjectCategoryID=2
                },
                new TrainingSubject
                {
                    TrainingSubjectID=7, SubjectName="iOS Development", TrainingSubjectCategoryID=2
                },
                new TrainingSubject
                {
                    TrainingSubjectID=8, SubjectName="Android App Programming", TrainingSubjectCategoryID=2
                },
                new TrainingSubject
                {
                    TrainingSubjectID=9, SubjectName="Principles of Software Testing", TrainingSubjectCategoryID=3
                },
                new TrainingSubject
                {
                    TrainingSubjectID=10, SubjectName="Test Automation", TrainingSubjectCategoryID=3
                },
                new TrainingSubject
                {
                    TrainingSubjectID=11, SubjectName="Visual Studio Test Manager", TrainingSubjectCategoryID=3
                },
                new TrainingSubject
                {
                    TrainingSubjectID=12, SubjectName="T-SQL Programming", TrainingSubjectCategoryID=4
                },
                new TrainingSubject
                {
                    TrainingSubjectID=13, SubjectName="Oracle Database Programming", TrainingSubjectCategoryID=4
                },
                new TrainingSubject
                {
                    TrainingSubjectID=14, SubjectName="LINQ and Entity Framework", TrainingSubjectCategoryID=4
                },

                //Agile Training
                new TrainingSubject
                {
                    TrainingSubjectID=15, SubjectName="ScrumMaster Training", TrainingSubjectCategoryID=5
                },
                new TrainingSubject
                {
                    TrainingSubjectID=16, SubjectName="Agile Developer Training", TrainingSubjectCategoryID=5
                },
                new TrainingSubject
                {
                    TrainingSubjectID=17, SubjectName="Scrum Product Owner", TrainingSubjectCategoryID=5
                },

                //Architecture
                new TrainingSubject
                {
                    TrainingSubjectID=18, SubjectName="TOGAF Overview", TrainingSubjectCategoryID=8
                },
                new TrainingSubject
                {
                    TrainingSubjectID=19, SubjectName="TOGAF Certification Preparation", TrainingSubjectCategoryID=8
                },
                new TrainingSubject
                {
                    TrainingSubjectID=20, SubjectName="Enterprise Architecture", TrainingSubjectCategoryID=8
                },
                new TrainingSubject
                {
                    TrainingSubjectID=21, SubjectName="Design Patterns - Part 1", TrainingSubjectCategoryID=7
                },
                new TrainingSubject
                {
                    TrainingSubjectID=22, SubjectName="Design Patterns - Part 2", TrainingSubjectCategoryID=7
                },
                new TrainingSubject
                {
                    TrainingSubjectID=23, SubjectName="SDLC Overview", TrainingSubjectCategoryID=6
                },

            };

            subjectDetails.ForEach(s => context.TrainingSubjects.Add(s));
            context.SaveChanges();

            var courseDetails = new List<TrainingCourse>
            {
                new TrainingCourse
                {
                    TrainingCourseID=1, TrainingSubjectID=1, StartDate=new DateTime(2014, 9, 1), EndDate=new DateTime(2014, 10, 31), Location="Bothell"
                },

                new TrainingCourse
                {
                    TrainingCourseID=2, TrainingSubjectID=2, StartDate=new DateTime(2014, 9, 1), EndDate=new DateTime(2014, 10, 31), Location="Bothell"
                },

                new TrainingCourse
                {
                    TrainingCourseID=3, TrainingSubjectID=3, StartDate=new DateTime(2014, 9, 1), EndDate=new DateTime(2014, 10, 31), Location="Bothell"
                },
                new TrainingCourse
                {
                    TrainingCourseID=4, TrainingSubjectID=4, StartDate=new DateTime(2014, 11, 1), EndDate=new DateTime(2014, 12, 31), Location="Bothell"
                },

                new TrainingCourse
                {
                    TrainingCourseID=5, TrainingSubjectID=5, StartDate=new DateTime(2014, 11, 1), EndDate=new DateTime(2014, 12, 31), Location="Bothell"
                },

                new TrainingCourse
                {
                    TrainingCourseID=6, TrainingSubjectID=6, StartDate=new DateTime(2014, 11, 1), EndDate=new DateTime(2014, 12, 31), Location="Bothell"
                },

                new TrainingCourse
                {
                    TrainingCourseID=7, TrainingSubjectID=7, StartDate=new DateTime(2015, 1, 1), EndDate=new DateTime(2015, 2, 28), Location="Bothell"
                },

                new TrainingCourse
                {
                    TrainingCourseID=8,  TrainingSubjectID=8, StartDate=new DateTime(2015, 1, 1), EndDate=new DateTime(2015, 2, 28), Location="Bothell"
                },

                new TrainingCourse
                {
                    TrainingCourseID=9, TrainingSubjectID=9, StartDate=new DateTime(2015, 1, 1), EndDate=new DateTime(2015, 2, 28), Location="Bothell"
                },

                new TrainingCourse
                {
                    TrainingCourseID=10, TrainingSubjectID=10, StartDate=new DateTime(2015, 3, 1), EndDate=new DateTime(2015, 4, 30), Location="Bothell"
                },

                new TrainingCourse
                {
                    TrainingCourseID=11, TrainingSubjectID=11, StartDate=new DateTime(2015, 3, 1), EndDate=new DateTime(2015, 4, 30), Location="Bothell"
                },

                new TrainingCourse
                {
                    TrainingCourseID=12, TrainingSubjectID=12, StartDate=new DateTime(2015, 3, 1), EndDate=new DateTime(2015, 4, 30), Location="Bothell"
                },

                new TrainingCourse
                {
                    TrainingCourseID=13, TrainingSubjectID=13, StartDate=new DateTime(2015, 5, 1), EndDate=new DateTime(2015, 6, 30), Location="Bothell"
                },

                new TrainingCourse
                {
                    TrainingCourseID=14, TrainingSubjectID=14, StartDate=new DateTime(2015, 5, 1), EndDate=new DateTime(2015, 6, 30), Location="Bothell"
                },

                new TrainingCourse
                {
                    TrainingCourseID=15, TrainingSubjectID=15, StartDate=new DateTime(2015, 5, 1), EndDate=new DateTime(2015, 6, 30), Location="Bothell"
                },

                new TrainingCourse
                {
                    TrainingCourseID=16, TrainingSubjectID=16, StartDate=new DateTime(2015, 7, 1), EndDate=new DateTime(2015, 8, 31), Location="Bothell"
                },

                new TrainingCourse
                {
                    TrainingCourseID=17, TrainingSubjectID=17, StartDate=new DateTime(2015, 7, 1), EndDate=new DateTime(2015, 8, 31), Location="Bothell"
                },

                new TrainingCourse
                {
                    TrainingCourseID=18, TrainingSubjectID=18, StartDate=new DateTime(2015, 7, 1), EndDate=new DateTime(2015, 8, 31), Location="Bothell"
                },

                new TrainingCourse
                {
                    TrainingCourseID=19, TrainingSubjectID=19, StartDate=new DateTime(2015, 9, 1), EndDate=new DateTime(2015, 10, 31), Location="Bothell"
                },

                new TrainingCourse
                {
                    TrainingCourseID=20, TrainingSubjectID=20, StartDate=new DateTime(2015, 9, 1), EndDate=new DateTime(2015, 10, 31), Location="Bothell"
                },

                new TrainingCourse
                {
                    TrainingCourseID=21, TrainingSubjectID=21, StartDate=new DateTime(2015, 9, 1), EndDate=new DateTime(2015, 10, 31), Location="Bothell"
                },

                new TrainingCourse
                {
                    TrainingCourseID=22, TrainingSubjectID=22, StartDate=new DateTime(2015, 9, 1), EndDate=new DateTime(2015, 10, 31), Location="Bothell"
                },
            };

            courseDetails.ForEach(c => context.TrainingCourses.Add(c));
            context.SaveChanges();

            var students = new List<Student>
            {
                new Student{ FirstName="John", LastName="Smith", Email="john@gmail.com", PhoneNumber= "425-555-5253", StudentId=1},
                new Student{ FirstName="Paul", LastName="Cook", Email="paul@gmail.com", PhoneNumber="555-425-5253", StudentId=2},
                new Student{ FirstName="Mike", LastName="Hooper", Email="mike@gmail.com", PhoneNumber="206-555-2222", StudentId=3}
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment { EnrollmentId=1, TrainingCourseId=1, StudentId=1, CurrentEnrollmentStage=EnrollmentStage.Enrolled},
                new Enrollment {EnrollmentId=2, TrainingCourseId=2, StudentId=2, CurrentEnrollmentStage=EnrollmentStage.Registered},
                new Enrollment {EnrollmentId=3, TrainingCourseId=3, StudentId=3, CurrentEnrollmentStage=EnrollmentStage.InComplete},
                new Enrollment {EnrollmentId=4, TrainingCourseId=4, StudentId=1, CurrentEnrollmentStage=EnrollmentStage.Registered},
                new Enrollment {EnrollmentId=5, TrainingCourseId=5, StudentId=2, CurrentEnrollmentStage=EnrollmentStage.Completed},
                new Enrollment {EnrollmentId=6, TrainingCourseId=6, StudentId=3, CurrentEnrollmentStage=EnrollmentStage.Registered}
            };

            enrollments.ForEach(e => context.Enrollments.Add(e));
            context.SaveChanges();

            var trainingCourseDurations = new List<TrainingCourseDuration>
            {
                new TrainingCourseDuration {TrainingCourseDurationId=1, DurationID=1, TrainingCourseId=1},
                new TrainingCourseDuration {TrainingCourseDurationId=2, DurationID=3, TrainingCourseId=1},
                new TrainingCourseDuration {TrainingCourseDurationId=3, DurationID=2, TrainingCourseId=1},
                
                new TrainingCourseDuration {TrainingCourseDurationId=4, DurationID=3, TrainingCourseId=22},                
                new TrainingCourseDuration {TrainingCourseDurationId=5, DurationID=4, TrainingCourseId=22},
                new TrainingCourseDuration {TrainingCourseDurationId=6, DurationID=5, TrainingCourseId=22},

                new TrainingCourseDuration {TrainingCourseDurationId=7, DurationID=1, TrainingCourseId=21},                
                new TrainingCourseDuration {TrainingCourseDurationId=8, DurationID=3, TrainingCourseId=21},
                new TrainingCourseDuration {TrainingCourseDurationId=9, DurationID=2, TrainingCourseId=21},

                new TrainingCourseDuration {TrainingCourseDurationId=10, DurationID=3, TrainingCourseId=20},                
                new TrainingCourseDuration {TrainingCourseDurationId=11, DurationID=4, TrainingCourseId=20},
                new TrainingCourseDuration {TrainingCourseDurationId=12, DurationID=5, TrainingCourseId=20},

                new TrainingCourseDuration {TrainingCourseDurationId=13, DurationID=3, TrainingCourseId=19},
                new TrainingCourseDuration {TrainingCourseDurationId=14, DurationID=4, TrainingCourseId=19},
                new TrainingCourseDuration {TrainingCourseDurationId=15, DurationID=5, TrainingCourseId=19},

                new TrainingCourseDuration {TrainingCourseDurationId=16, DurationID=1, TrainingCourseId=18}, 
                new TrainingCourseDuration {TrainingCourseDurationId=17, DurationID=3, TrainingCourseId=18},
                new TrainingCourseDuration {TrainingCourseDurationId=18, DurationID=2, TrainingCourseId=18},

                new TrainingCourseDuration {TrainingCourseDurationId=19, DurationID=3, TrainingCourseId=17},                
                new TrainingCourseDuration {TrainingCourseDurationId=20, DurationID=4, TrainingCourseId=17},
                new TrainingCourseDuration {TrainingCourseDurationId=21, DurationID=5, TrainingCourseId=17},

                new TrainingCourseDuration {TrainingCourseDurationId=22, DurationID=1, TrainingCourseId=16},                
                new TrainingCourseDuration {TrainingCourseDurationId=23, DurationID=3, TrainingCourseId=16},
                new TrainingCourseDuration {TrainingCourseDurationId=24, DurationID=2, TrainingCourseId=16},
            };

            trainingCourseDurations.ForEach(t => context.TrainingCourseDurations.Add(t));
            context.SaveChanges();

            var trainingSubjectSyllabuses = new List<TrainingSubjectSyllabus>
            {
                new TrainingSubjectSyllabus {TrainingSubjectSyllabusID=1, SyllabusID=1, TrainingSubjectID=1},
                new TrainingSubjectSyllabus {TrainingSubjectSyllabusID=2, SyllabusID=2, TrainingSubjectID=1},
                new TrainingSubjectSyllabus {TrainingSubjectSyllabusID=3, SyllabusID=3, TrainingSubjectID=1},
                new TrainingSubjectSyllabus {TrainingSubjectSyllabusID=4, SyllabusID=4, TrainingSubjectID=1},

                new TrainingSubjectSyllabus {TrainingSubjectSyllabusID=5, SyllabusID=13, TrainingSubjectID=2},
                new TrainingSubjectSyllabus {TrainingSubjectSyllabusID=6, SyllabusID=14, TrainingSubjectID=2},
                new TrainingSubjectSyllabus {TrainingSubjectSyllabusID=7, SyllabusID=15, TrainingSubjectID=2},
                new TrainingSubjectSyllabus {TrainingSubjectSyllabusID=8, SyllabusID=16, TrainingSubjectID=2},

                new TrainingSubjectSyllabus {TrainingSubjectSyllabusID=9, SyllabusID=5, TrainingSubjectID=10},
                new TrainingSubjectSyllabus {TrainingSubjectSyllabusID=10, SyllabusID=6, TrainingSubjectID=10},
                new TrainingSubjectSyllabus {TrainingSubjectSyllabusID=11, SyllabusID=7, TrainingSubjectID=10},
                new TrainingSubjectSyllabus {TrainingSubjectSyllabusID=12, SyllabusID=8, TrainingSubjectID=10},
                new TrainingSubjectSyllabus {TrainingSubjectSyllabusID=13, SyllabusID=9, TrainingSubjectID=10},

            };

            trainingSubjectSyllabuses.ForEach(t => context.TrainingSubjectSyllabuses.Add(t));
            context.SaveChanges();

            var trainingSubjectPreRequisites = new List<TrainingSubjectPreRequisite>
            {
                new TrainingSubjectPreRequisite {TrainingSubjectPreRequisiteID=1, TrainingSubjectID=1, PreRequisiteID=1},
                new TrainingSubjectPreRequisite {TrainingSubjectPreRequisiteID=2, TrainingSubjectID=1, PreRequisiteID=2},
                new TrainingSubjectPreRequisite {TrainingSubjectPreRequisiteID=3, TrainingSubjectID=1, PreRequisiteID=3},

                new TrainingSubjectPreRequisite {TrainingSubjectPreRequisiteID=4, TrainingSubjectID=2, PreRequisiteID=4},
                new TrainingSubjectPreRequisite {TrainingSubjectPreRequisiteID=5, TrainingSubjectID=2, PreRequisiteID=1},
                new TrainingSubjectPreRequisite {TrainingSubjectPreRequisiteID=6, TrainingSubjectID=2, PreRequisiteID=2},

                new TrainingSubjectPreRequisite {TrainingSubjectPreRequisiteID=7, TrainingSubjectID=10, PreRequisiteID=3},
                new TrainingSubjectPreRequisite {TrainingSubjectPreRequisiteID=8, TrainingSubjectID=10, PreRequisiteID=4},
                new TrainingSubjectPreRequisite {TrainingSubjectPreRequisiteID=9, TrainingSubjectID=10, PreRequisiteID=1},
            };

            trainingSubjectPreRequisites.ForEach(t => context.TrainingSubjectPreRequisites.Add(t));
            context.SaveChanges();
        }
    }
}
