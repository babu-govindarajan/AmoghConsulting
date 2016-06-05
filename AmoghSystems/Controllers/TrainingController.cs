using AmoghSystems.Models;
using DatabaseInterface;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AmoghSystems.Mailers;
using DatabaseImplementation;

namespace AmoghSystems.Controllers
{
    public class TrainingController : Controller
    {
        ITrainingInterface trainingInterface = new TrainingDataProvider();

        // GET: Training
        public ActionResult Index()
        {
            var trainingOverviewModel = new TrainingOverviewModel();

            trainingOverviewModel.TrainingCategoryData = trainingInterface.GetTrainingOverviewData();

            return View(trainingOverviewModel);
        }

        public ActionResult Training(string id)
        {
            int trainingCategoryID = Int32.Parse(id);

            var trainingCategoryOverview = new TrainingCategoryOverview();

            trainingCategoryOverview.TrainingCategoryOverviewData = trainingInterface.GetTrainingCategoryOverviewData(trainingCategoryID);

            return View(trainingCategoryOverview);
        }
        
        public ActionResult TrainingDetails(string id, string subId)
        {            
            int subjectId = int.Parse(subId);

            var mds = new ModelDataService();

            List<TrainingCourseModel> trainingCourseModels = mds.GetTrainingCourseModel(subjectId);

            return View(trainingCourseModels);
        }
        
        [AllowAnonymous]
        public ActionResult Register(string id, string subId)
        {
            ViewBag.SubjectName = trainingInterface.GetSubjectNameById(int.Parse(subId));
            ViewBag.SubjectId = subId;
            ViewBag.CourseId = id;

            var modelDataService = new ModelDataService();

            var model = new RegisterTrainingModel
                {
                    EducationalLevels = new SelectList(modelDataService.GetEducationSelectList(), "Value", "Text"),
                    ExperienceLevels = new SelectList(modelDataService.GetExperienceSelectList(), "Value", "Text")
                };

            return View(model);
        }

        [RequireHttps]
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterTrainingModel model)
        {
            var modelDataService = new ModelDataService();
            var modelReturn = new RegisterTrainingModel
            {
                EducationalLevels = new SelectList(modelDataService.GetEducationSelectList(), "Value", "Text"),
                ExperienceLevels = new SelectList(modelDataService.GetExperienceSelectList(), "Value", "Text")
            };

            if(model.ExperienceSelectedId == 0) 
            {
                ViewBag.ExperienceLevelErrorMsg = "Please select your experience level";                
            }

            if (model.EducationalLevelSelectedId == 0)
            {
                ViewBag.EducationalErrorMsg = "Please select your educational level";                
            }

            if ((model.ExperienceSelectedId == 0) || (model.EducationalLevelSelectedId == 0))
            {
                return View(modelReturn);
            }

            if(ModelState.IsValid)
            {
                //Update records in database                                
                modelDataService.CreateTrainingRegistration(model);

                RegisterTrainingMessageModel registerTrainingMessage = modelDataService.GetTrainingRegistrationNotificationMessage(model);

                //Send email notification to Training Admin to contact Student
                IUserMailer userMailer = new UserMailer();
                userMailer.NotifyTrainingCoordinator(registerTrainingMessage).Send();

                return RedirectToAction("ThankYou", "Training", new { StudentName = string.Format(model.FirstName + " " + model.LastName) });
            }
                        
            return View(modelReturn);
        }

        public ActionResult ThankYou(string studentName)
        {
            ViewBag.StudentName = studentName;
            return View();
        }


        public ActionResult SoftwareDevelopment(string course)
        {
            return PartialView("_SoftwareDevelopment");
        }
    }
}