using System;
using System.Collections.Generic;
using System.Linq;
using DataAccessLayer;
using DatabaseInterface;

namespace DatabaseImplementation
{
    public class TrainingDataProvider : ITrainingInterface
    {
        public List<TrainingOverview> GetAllTrainingsOverview()
        {
            using (var trainingContext = new TrainingContext())
            {
                var trainingSubjectCategories = from tsc in trainingContext.TrainingSubjectCategories
                                                select tsc;

                //For each TrainingCategory, Get TrainingSubjectCategory
                var trainingOverviews = new List<TrainingOverview>();
                foreach (var tsc in trainingSubjectCategories)
                {
                    var to = new TrainingOverview
                    {
                        TrainingSubjectCategoryID = tsc.TrainingSubjectCategoryID,
                        TrainingSubjectCategoryDescription = tsc.Description,
                        TrainingCategoryID = tsc.TrainingCategoryID,
                        TrainingCategoryDescription = tsc.TrainingCategory.Description
                    };
                    trainingOverviews.Add(to);
                }

                trainingOverviews.Sort();
                return trainingOverviews;
            }
        }

        public string GetSubjectNameById(int subjectId)
        {
            using (var trainingContext = new TrainingContext())
            {
                var trainingSubject = from ts in trainingContext.TrainingSubjects
                                      where ts.TrainingSubjectID == subjectId
                                      select ts;
                var firstOrDefault = trainingSubject.FirstOrDefault();

                if (firstOrDefault != null) 
                    return firstOrDefault.SubjectName;
            }
            return null;
        }

        public  List<TrainingCourse> GetTrainingCourseDetails(TrainingContext tc,  int trainingSubjectId)
        {            
            var trainingCourses = from tcs in tc.TrainingCourses
                                    where tcs.TrainingSubjectID == trainingSubjectId
                                    select tcs;
            
            return trainingCourses.ToList();                            
        }

        public List<TrainingSubject> GetTrainingSubjectsByTrainingCategory(int trainingCategoryId)
        {
            var trainingSubjects = new List<TrainingSubject>();

            //Using TrainingCategoryID, get all TrainingSubjectCategory.
            using (var tc = new TrainingContext())
            {
                var trainingSubjectCategories = from tsc in tc.TrainingSubjectCategories
                                                where tsc.TrainingCategoryID == trainingCategoryId
                                                select tsc;
                //For each TrainingSubjectCategory, get all TrainingSubjects.
                foreach (var tsc in trainingSubjectCategories)
                {
                    var currentTrainingSubjects = from ts in tc.TrainingSubjects
                                                  where ts.TrainingSubjectCategoryID == tsc.TrainingSubjectCategoryID
                                                  select ts;
                    trainingSubjects.AddRange(currentTrainingSubjects);
                }

                return trainingSubjects;    
            }
        }

        public Dictionary<TrainingCategory, Dictionary<TrainingSubjectCategory, List<TrainingSubject>>> GetTrainingOverviewData()
        {
            var trainingCategoriesDict = new Dictionary<TrainingCategory, Dictionary<TrainingSubjectCategory, List<TrainingSubject>>>();

            using (var tc = new TrainingContext())
            {
                var trainingCategories = from tCategories in tc.TrainingCategories
                                         select tCategories;

                foreach (var trainingCategory in trainingCategories)
                {
                    var trainingSubCategories = new Dictionary<TrainingSubjectCategory, List<TrainingSubject>>();

                    var trainingSubjectCategories = from tSubjectCategories in tc.TrainingSubjectCategories
                                                    where tSubjectCategories.TrainingCategoryID == trainingCategory.TrainingCategoryID
                                                    select tSubjectCategories;

                    foreach (TrainingSubjectCategory trainingSubjectCategory in trainingSubjectCategories)
                    {

                        var trainingSubjects = from tSubjects in tc.TrainingSubjects
                                               where tSubjects.TrainingSubjectCategoryID == trainingSubjectCategory.TrainingSubjectCategoryID
                                               select tSubjects;

                        var trainingSubs = new List<TrainingSubject>();
                        foreach (TrainingSubject trainingSubject in trainingSubjects)
                        {
                            trainingSubs.Add(trainingSubject);
                        }

                        trainingSubCategories.Add(trainingSubjectCategory, trainingSubs);
                    }

                    trainingCategoriesDict.Add(trainingCategory, trainingSubCategories);
                }

                return trainingCategoriesDict;    
            }
        }

        public Dictionary<TrainingSubjectCategory, List<TrainingSubject>> GetTrainingCategoryOverviewData(int trainingCategoryId)
        {
            using (var tc = new TrainingContext())
            {
                var trainingCategory = from trainingCate in tc.TrainingCategories
                                       where trainingCate.TrainingCategoryID == trainingCategoryId
                                       select trainingCate;

                if (trainingCategory.FirstOrDefault() == null)
                {
                    throw new Exception("Unable to locate Training Category from Data Source");
                }

                var trainingSubjectCategoryResult = new Dictionary<DataAccessLayer.TrainingSubjectCategory, List<TrainingSubject>>();

                var trainingSubjectCategories = from tSubjectCategories in tc.TrainingSubjectCategories
                                                where tSubjectCategories.TrainingCategoryID == trainingCategory.FirstOrDefault().TrainingCategoryID
                                                select tSubjectCategories;

                foreach (var trainingSubjectCategory in trainingSubjectCategories)
                {

                    var trainingSubjects = from tSubjects in tc.TrainingSubjects
                                           where tSubjects.TrainingSubjectCategoryID == trainingSubjectCategory.TrainingSubjectCategoryID
                                           select tSubjects;

                    var trainingSubs = new List<TrainingSubject>();
                    foreach (var trainingSubject in trainingSubjects)
                    {
                        trainingSubs.Add(trainingSubject);
                    }

                    trainingSubjectCategoryResult.Add(trainingSubjectCategory, trainingSubs);
                }

                return trainingSubjectCategoryResult;
            }
        }
    }
}
