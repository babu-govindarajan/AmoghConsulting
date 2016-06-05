using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer;
using DatabaseInterface;
using DatabaseImplementation;

namespace AmoghSystems.Models
{
    public class ModelDataService
    {
        public void GetAreaOfInterest()
        {}

        public void CreateContactUsMessage(ContactUsMessage contactUsMessage)
        {
            var contactUs = new ContactUs
                {
                    FirstName = contactUsMessage.FirstName,
                    LastName = contactUsMessage.LastName,
                    Email = contactUsMessage.Email,
                    PhoneNumber = contactUsMessage.PhoneNumber,
                    ItConsulting = contactUsMessage.ItConsulting,
                    Solutions = contactUsMessage.Solutions,
                    Training = contactUsMessage.Training,
                    Message = contactUsMessage.Message,
                    Response = "Received"
                };
            using (var tc = new TrainingContext())
            {
                tc.ContactUses.Add(contactUs);
                tc.SaveChanges();
            }
        }

        public void CreateTrainingRegistration(RegisterTrainingModel registerTrainingModel)
        {
            var student = new Student
            {
                FirstName = registerTrainingModel.FirstName,
                LastName = registerTrainingModel.LastName,
                Email = registerTrainingModel.Email,
                PhoneNumber = registerTrainingModel.PhoneNumber,
                ItExperience = ExperienceLevel.GetExperienceLevelDescription(registerTrainingModel.ExperienceSelectedId),
                EducationalQualification = EducationalLevel.GetEducationLevelDescription(registerTrainingModel.EducationalLevelSelectedId),
                HowKnowAboutUs = registerTrainingModel.HowDidYouKnowUs,
                Message = registerTrainingModel.Message,
            };
            using (var tc = new TrainingContext())
            {
                tc.Students.Add(student);
                tc.SaveChanges();

                var students = from s in tc.Students
                               where s.FirstName == registerTrainingModel.FirstName
                                     && s.LastName == registerTrainingModel.LastName
                               select s;
                var firstOrDefault = students.FirstOrDefault();
                if (firstOrDefault != null)
                {
                    int studentId = firstOrDefault.StudentId;

                    var enrollment = new Enrollment
                    {
                        TrainingCourseId = registerTrainingModel.CourseId,
                        StudentId = studentId,
                        CurrentEnrollmentStage = EnrollmentStage.Registered
                    };
                    tc.Enrollments.Add(enrollment);
                    tc.SaveChanges();
                }
            }
        }

        public string GetSubjectName(int subjectId)
        {
            using (var tc = new TrainingContext())
            {
                var trainingSubject = from s in tc.TrainingSubjects
                                 where s.TrainingSubjectID == subjectId
                                 select s;

                if (trainingSubject.FirstOrDefault() != null)
                {
                    return trainingSubject.FirstOrDefault().SubjectName;                    
                }
            }

            return null;
        }
        
        public CourseMessageModel GetCourseMessageModel(RegisterTrainingModel registerTraining)
        {
            var courseMessage = new CourseMessageModel();

            using (var tc = new TrainingContext())
            {
                var trainingCouses = from c in tc.TrainingCourses
                                     where c.TrainingCourseID == registerTraining.CourseId
                                     select c;
                if (trainingCouses.FirstOrDefault() != null)
                {
                    var trainingCouse = trainingCouses.FirstOrDefault();
                    courseMessage.StartDate = trainingCouse.StartDate;
                    courseMessage.EndDate = trainingCouse.EndDate;
                    courseMessage.Location = trainingCouse.Location;

                    var trainingCourseDurations = from tcd in tc.TrainingCourseDurations
                              where tcd.TrainingCourseId == registerTraining.CourseId
                              select tcd;


                    var durations = new List<string>();
                    
                    foreach (TrainingCourseDuration trainingCourseDuration in trainingCourseDurations)
                    {
                        var duration = from d in tc.Durations
                                        where d.DurationID == trainingCourseDuration.DurationID
                                        select d;

                        if (duration.FirstOrDefault() != null)
                        {
                            durations.Add(duration.FirstOrDefault().DayTime);
                        }

                    }

                    courseMessage.Duration = durations.ToArray();
                }
            }
            return courseMessage;
        }

        public RegisterTrainingMessageModel GetTrainingRegistrationNotificationMessage(RegisterTrainingModel registerTrainingModel)
        {
            var messageModel = new RegisterTrainingMessageModel
                {
                    ExperienceLevel = ExperienceLevel.GetExperienceLevelDescription(registerTrainingModel.ExperienceSelectedId),
                    EducationalLevel = EducationalLevel.GetEducationLevelDescription(registerTrainingModel.EducationalLevelSelectedId),
                    SubjectName = GetSubjectName(registerTrainingModel.SubjectId),
                    Email = registerTrainingModel.Email,
                    FirstName = registerTrainingModel.FirstName,
                    LastName = registerTrainingModel.LastName,
                    HowDidYouKnowUs = registerTrainingModel.HowDidYouKnowUs,
                    Message = registerTrainingModel.Message,
                    PhoneNumber = registerTrainingModel.PhoneNumber,
                    CourseMessageModel = GetCourseMessageModel(registerTrainingModel),                    
                };
            return messageModel;
        }


        public List<SelectListItem> GetExperienceSelectList()
        {
            var selectListItemSelectExp = new SelectListItem
            {
                Text = ExperienceLevel.SelectExp.Description,
                Value = ExperienceLevel.SelectExp.Id.ToString(CultureInfo.CurrentCulture)
            };

            var selectListItemSde = new SelectListItem
            {
                Text = ExperienceLevel.Sde.Description,
                Value = ExperienceLevel.Sde.Id.ToString(CultureInfo.CurrentCulture)
            };

            var selectListItemSdet = new SelectListItem
            {
                Text = ExperienceLevel.Sdet.Description,
                Value = ExperienceLevel.Sdet.Id.ToString(CultureInfo.CurrentCulture)
            };

            var selectListItemTester = new SelectListItem
            {
                Text = ExperienceLevel.Tester.Description,
                Value = ExperienceLevel.Tester.Id.ToString(CultureInfo.CurrentCulture)
            };

            var selectListItemOtherItExp = new SelectListItem
            {
                Text = ExperienceLevel.OtherItExp.Description,
                Value = ExperienceLevel.OtherItExp.Id.ToString(CultureInfo.CurrentCulture)
            };

            var selectListItemNoExp = new SelectListItem
            {
                Text = ExperienceLevel.NoExp.Description,
                Value = ExperienceLevel.NoExp.Id.ToString(CultureInfo.CurrentCulture)
            };

            var experienceList = new List<SelectListItem>
                {
                    selectListItemSelectExp,
                    selectListItemSde,
                    selectListItemSdet,
                    selectListItemTester,
                    selectListItemOtherItExp,
                    selectListItemNoExp
                };

            return experienceList;
        }

        public List<SelectListItem> GetEducationSelectList()
        {
            var selectListItemHighSchool = new SelectListItem
            {
                Text = EducationalLevel.HighSchool.Description,
                Value = EducationalLevel.HighSchool.Id.ToString(CultureInfo.CurrentCulture)
            };

            var selectListItemGraduate = new SelectListItem
            {
                Text = EducationalLevel.Graduate.Description,
                Value = EducationalLevel.Graduate.Id.ToString(CultureInfo.CurrentCulture)
            };

            var selectListItemPostGraduate = new SelectListItem
            {
                Text = EducationalLevel.PostGraduate.Description,
                Value = EducationalLevel.PostGraduate.Id.ToString(CultureInfo.CurrentCulture)
            };

            var selectListItemSelectEducationLevel = new SelectListItem
            {
                Text = EducationalLevel.SelectEducation.Description,
                Value = EducationalLevel.SelectEducation.Id.ToString(CultureInfo.CurrentCulture)
            };

            var educationList = new List<SelectListItem>
                {
                    selectListItemSelectEducationLevel,
                    selectListItemHighSchool,
                    selectListItemGraduate,
                    selectListItemPostGraduate,                    
                };

            return educationList;
        }

        public List<TrainingCourseModel> GetTrainingCourseModel(int subjectId)
        {
            List<TrainingCourseModel> trainingCourseModels = new List<TrainingCourseModel>();

            ITrainingInterface trainingInterface = new TrainingDataProvider();

            using (var tc = new DataAccessLayer.TrainingContext())
            {
                List<DataAccessLayer.TrainingCourse> trainingCourses = trainingInterface.GetTrainingCourseDetails(tc, subjectId);

                foreach (TrainingCourse trainingCourse in trainingCourses)
                {
                    var trainingCourseModel = new TrainingCourseModel();
                    trainingCourseModel.Location = trainingCourse.Location;
                    trainingCourseModel.EndDate = trainingCourse.EndDate;
                    trainingCourseModel.StartDate = trainingCourse.StartDate;
                    trainingCourseModel.TrainingCouseId = trainingCourse.TrainingCourseID;
                    trainingCourseModel.TrainingSubjectId = trainingCourse.TrainingSubjectID;

                    //Training Subject correspond to the course
                    var trainingSubject = from ts in tc.TrainingSubjects
                                          where ts.TrainingSubjectID == trainingCourse.TrainingSubjectID
                                          select ts;

                    //Assign TrainingSubject attributes to Model object
                    var firstOrDefault = trainingSubject.FirstOrDefault();
                    if (firstOrDefault != null)
                    {
                        trainingCourseModel.TrainingSubjectCategoryId = firstOrDefault.TrainingSubjectCategoryID;
                        trainingCourseModel.SubjectName = firstOrDefault.SubjectName;
                    }

                    //Load Duration for the training Course
                    var trainingCourseDurations = from tcd in tc.TrainingCourseDurations
                                                  where tcd.TrainingCourseId == trainingCourse.TrainingCourseID
                                                  select tcd;
                    foreach (TrainingCourseDuration trainingCourseDuration in trainingCourseDurations)
                    {
                        var durations = from d in tc.Durations
                                        where d.DurationID == trainingCourseDuration.DurationID
                                        select d;
                        var duration = durations.FirstOrDefault();
                        if (duration != null)
                            trainingCourseModel.Durations.Add(duration.DayTime);
                    }

                    //Load PreRequisites
                    var trainingSubjectPreRequisites = from tspr in tc.TrainingSubjectPreRequisites
                                                       where
                                                           tspr.TrainingSubjectID == trainingSubject.FirstOrDefault().TrainingSubjectID
                                                       select tspr;
                    foreach (TrainingSubjectPreRequisite trainingSubjectPreReq in trainingSubjectPreRequisites)
                    {
                        var preRequisites = from pr in tc.PreRequisites
                                            where pr.PreRequisiteID ==
                                                trainingSubjectPreReq.PreRequisiteID
                                            select pr;
                        var preRequisite = preRequisites.FirstOrDefault();
                        if (preRequisite != null)
                            trainingCourseModel.PreRequisites.Add(preRequisite.Description);
                    }

                    //Load Syllabus
                    var trainingSubjectSyllabuses = from tss in tc.TrainingSubjectSyllabuses
                                                    where tss.TrainingSubjectID == trainingSubject.FirstOrDefault().TrainingSubjectID
                                                    select tss;
                    foreach (TrainingSubjectSyllabus trainingSubjectSyllabus in trainingSubjectSyllabuses)
                    {
                        var syllabuses = from s in tc.Syllabuses
                                         where s.SyllabusID ==
                                             trainingSubjectSyllabus.SyllabusID
                                         select s;
                        var syllabus = syllabuses.FirstOrDefault();
                        if (syllabus != null)
                            trainingCourseModel.Syllabuses.Add(syllabus.Description);
                    }

                    trainingCourseModels.Add(trainingCourseModel);
                }
            }

            return trainingCourseModels;
        }
    }
}