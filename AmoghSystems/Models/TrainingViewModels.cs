using System.Globalization;
using DataAccessLayer;
using DatabaseInterface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmoghSystems.Models
{
    public class TrainingOverviewModel
    {
        public Dictionary<TrainingCategory, Dictionary<TrainingSubjectCategory, List<TrainingSubject>>> TrainingCategoryData { get; set; }        
    }

    public class TrainingCategoryOverview
    {
        public Dictionary<TrainingSubjectCategory, List<TrainingSubject>> TrainingCategoryOverviewData { get; set; }

    }

    public class TrainingCourseModel
    {
        public int TrainingCouseId { get; set; }
        public int TrainingSubjectId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Location { get; set; }
        public string SubjectName { get; set; }        
        public int TrainingSubjectCategoryId { get; set; }
        public List<string> PreRequisites { get; set; }
        public List<string> Syllabuses { get; set; }
        public List<string> Durations { get; set; }        

        public TrainingCourseModel()
        {
            PreRequisites = new List<string>();
            Syllabuses = new List<string>();
            Durations = new List<string>();
        }
    }

    [Serializable]
    public class EducationalLevel
    {
        public int Id { get; set; }
        public string Description { get; set; }

        private EducationalLevel(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public static EducationalLevel SelectEducation = new EducationalLevel(0, "Select your Educational Qualification");
        public static EducationalLevel HighSchool = new EducationalLevel(1, "High School");
        public static EducationalLevel Graduate = new EducationalLevel(2, "Graduate");
        public static EducationalLevel PostGraduate = new EducationalLevel(3, "Post Graduate");        

        public static string GetEducationLevelDescription(int id)
        {
            if (HighSchool.Id == id)
                return HighSchool.Description;
            if (Graduate.Id == id)
                return Graduate.Description;
            if (PostGraduate.Id == id)
                return PostGraduate.Description;
            if (SelectEducation.Id == id)
                return SelectEducation.Description;
            return null;
        }
    }

    [Serializable]
    public class ExperienceLevel
    {
        public int Id { get; set; }
        public string Description { get; set; }

        private ExperienceLevel(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public static ExperienceLevel SelectExp = new ExperienceLevel(0, "Select your IT Experience");
        public static ExperienceLevel Sde = new ExperienceLevel(1, "Software Developer");
        public static ExperienceLevel Sdet = new ExperienceLevel(2, "Software Tester (Automation)");
        public static ExperienceLevel Tester = new ExperienceLevel(3, "Software Tester (Manual)");
        public static ExperienceLevel OtherItExp = new ExperienceLevel(4, "Other IT Experience");
        public static ExperienceLevel NoExp = new ExperienceLevel(5, "No IT Experience");
        

        public static string GetExperienceLevelDescription(int id)
        {
            if (Sde.Id == id)
                return Sde.Description;
            if (Sdet.Id == id)
                return Sdet.Description;
            if (Tester.Id == id)
                return Tester.Description;
            if (OtherItExp.Id == id)
                return OtherItExp.Description;
            if (NoExp.Id == id)
                return NoExp.Description;
            if (SelectExp.Id == id)
                return SelectExp.Description;
            return null;
        }        
    }

    public class EducationQualification
    {
        public EducationalLevel EducationLevel { get; set; }

        public EducationQualification(EducationalLevel educationLevel)
        {
            EducationLevel = educationLevel;
        }
    }
    
    public class ITWorkExperience
    {
        public ExperienceLevel ExperienceLevel { get; set; }

        public ITWorkExperience(ExperienceLevel experienceLevel)
        {
            ExperienceLevel = experienceLevel;
        }
    }

    public class RegisterTrainingModel
    {
        public SelectList EducationalLevels { get; set; }

        public SelectList ExperienceLevels { get; set; }
        
        [Required]
        public int EducationalLevelSelectedId { get; set; }

        [Required]
        public int ExperienceSelectedId { get; set; }

        [HiddenInput]
        [Display(Name = "SubjectId")]
        public int SubjectId { get; set; }

        [HiddenInput]
        [Display(Name = "CourseId")]
        public int CourseId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name="First Name")]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name="Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]        
        [Display(Name="Email Address")]
        public string Email { get; set; }

        [Required]
        [Phone]
        [Display(Name="Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name="How did you know about us?")]
        public string HowDidYouKnowUs { get; set; }
        
        [DataType(DataType.Text)]
        [Display(Name="Message")]
        public string Message { get; set; }
    }

    public class RegisterTrainingMessageModel
    {
        public string EducationalLevel { get; set; }
        public string ExperienceLevel { get; set; }
        public string SubjectName { get; set; }        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string HowDidYouKnowUs { get; set; }
        public string Message { get; set; }
        public CourseMessageModel CourseMessageModel { get; set; }
    }    

    public class CourseMessageModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string[] Duration { get; set; }
        public string Location { get; set; }
    }
}