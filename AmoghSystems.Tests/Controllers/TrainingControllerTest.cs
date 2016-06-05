using AmoghSystems.Controllers;
using AmoghSystems.Models;
using Moq;
using AmoghSystems.Mailers;
using NUnit.Framework;
using Mvc.Mailer;
using Assert = NUnit.Framework.Assert;
using System.Web.Mvc;

namespace AmoghSystems.Tests.Controllers
{
    [TestFixture]
    public class TrainingControllerTest
    {
        private TrainingController _trainingController;
        private Mock<IUserMailer> _userMailerMock;
        
        [SetUp]
        public void Setup()
        {
        }

        [TearDown]
        public void TearDown()
        {
            TestSmtpClient.SentMails.Clear();
        }

        [Test]
        public void Test_SendWelcomeMessage()
        {
            //Arrange
            var mailMessage = new MvcMailMessage();
            _userMailerMock.Setup(userMailer => userMailer.Welcome()).Returns(mailMessage);
            var trainingModel = new RegisterTrainingModel();

            //Act
            var actionResult = _trainingController.Register(trainingModel);

            //Assert
            _userMailerMock.VerifyAll();
            Assert.AreEqual(1, TestSmtpClient.SentMails.Count);
            Assert.AreEqual(mailMessage, TestSmtpClient.SentMails[0]);

            var routeValues = (actionResult as RedirectToRouteResult).RouteValues;
            Assert.AreEqual(routeValues["action"], "Index");
        }
    }
}
