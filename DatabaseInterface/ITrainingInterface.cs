using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace DatabaseInterface
{
    public interface ITrainingInterface
    {
        //List<TrainingOverview> GetAllTrainingsOverview();
        List<TrainingCourse> GetTrainingCourseDetails(TrainingContext tc, int trainingSubjectId);
        List<TrainingSubject> GetTrainingSubjectsByTrainingCategory(int trainingCategoryId);
        Dictionary<TrainingCategory, Dictionary<TrainingSubjectCategory, List<TrainingSubject>>> GetTrainingOverviewData();
        Dictionary<TrainingSubjectCategory, List<TrainingSubject>> GetTrainingCategoryOverviewData(int trainingCategoryId);
        string GetSubjectNameById(int subjectId);
    }
}
