using AmoghSystems.Models;
using Mvc.Mailer;

namespace AmoghSystems.Mailers
{ 
    public class UserMailer : MailerBase, IUserMailer 	
	{
		public UserMailer()
		{
			MasterName="_Layout";
		}
		
		public virtual MvcMailMessage Welcome()
		{
			ViewBag.Name = "Babu Govindarajan";
			return Populate(x =>
			{
				x.Subject = "Welcome";
				x.ViewName = "Welcome";
				x.To.Add("cg.babu@gmail.com");
			});
		}
 
		public virtual MvcMailMessage PasswordReset()
		{
			//ViewBag.Data = someObject;
			return Populate(x =>
			{
				x.Subject = "PasswordReset";
				x.ViewName = "PasswordReset";
				x.To.Add("some-email@example.com");
			});
		}

        public MvcMailMessage NotifyTrainingCoordinator(RegisterTrainingMessageModel registerTrainingModel)
        {

            string messageBody =
                string.Format("Training Subject: {0} \n " +
                              "Location: {1} \n " +
                              "Start Date: {2} \n " +
                              "End Date: {3} \n" +
                              "Student First Name: {4} \n" +
                              "Student Last Name: {5} \n" +
                              "Student Phone Number: {6} \n" +
                              "Student Email Id: {7} \n", 
                              registerTrainingModel.SubjectName,
                              registerTrainingModel.CourseMessageModel.Location,
                              registerTrainingModel.CourseMessageModel.StartDate,
                              registerTrainingModel.CourseMessageModel.EndDate,
                              registerTrainingModel.FirstName,
                              registerTrainingModel.LastName,
                              registerTrainingModel.PhoneNumber,
                              registerTrainingModel.Email);            

            return Populate(x =>
                {
                    x.ViewName = "NotifyTrainingCoordinator";
                    x.To.Add("amogh.systems@gmail.com");
                    x.Subject = "Training Registration";
                    x.Body = messageBody;
                });
        }
	}
}