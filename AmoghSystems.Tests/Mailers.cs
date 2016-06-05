using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using AmoghSystems.Mailers;
using NUnit.Framework;
using Mvc.Mailer;
using Assert = NUnit.Framework.Assert;

namespace AmoghSystems.Tests
{
    [TestClass]
    public class Mailers
    {
        private Mock<UserMailer> _userMailerMock;

       [SetUp]
       public void Setup()
       {
           _userMailerMock = new Mock<UserMailer>();
           _userMailerMock.CallBase = true;
       }

       [Test]
       public void Test_WelcomeMessage()
       {
           //Arrange
           _userMailerMock.Setup(
               mailer => mailer.PopulateBody(It.IsAny<MvcMailMessage>(), "Welcome", It.IsAny<string>(), null));

           //Act
           var mailMessage = _userMailerMock.Object.Welcome();

           //Assert
           _userMailerMock.VerifyAll();
           Assert.AreEqual("Babu Govindarajan", _userMailerMock.Object.ViewBag.Name);
           Assert.AreEqual("Welcome to Prodigy Consulting", mailMessage.Subject);
           Assert.AreEqual("cg.babu@gmail.com", mailMessage.To.First().ToString());
       }


    }
}
