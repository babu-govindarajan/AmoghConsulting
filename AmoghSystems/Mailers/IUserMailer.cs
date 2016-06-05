using AmoghSystems.Models;
using Mvc.Mailer;

namespace AmoghSystems.Mailers
{ 
    public interface IUserMailer
    {
			MvcMailMessage Welcome();
			MvcMailMessage PasswordReset();
            MvcMailMessage NotifyTrainingCoordinator(RegisterTrainingMessageModel registerTrainingModel);
    }
}