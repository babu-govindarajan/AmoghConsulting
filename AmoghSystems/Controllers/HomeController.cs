using AmoghSystems.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmoghSystems.Controllers
{    
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [RequireHttps]
        [AcceptVerbs("GET")]
        public ActionResult ContactUs()
        {
            return View();
        }

        [AcceptVerbs("POST")]
        [RequireHttps]
        public ActionResult ContactUs(ContactUsMessage contactUsMessage)
        {
            if (contactUsMessage.ItConsulting == false && contactUsMessage.Solutions == false &&
                contactUsMessage.Training == false)
            {
                ViewBag.AreaOfInterestErrorMsg = "Please select your Area of Interest";
                return View();
            }                

            if (ModelState.IsValid)
            {
                ModelDataService modelDataService = new ModelDataService();
                modelDataService.CreateContactUsMessage(contactUsMessage);
                return RedirectToAction("ThankYou", "Training");
            }

            return View();
        }

        public ActionResult Web()
        {        
            return View();
        }

        public ActionResult Cloud()
        {
            return View();
        }

        public ActionResult Mobile()
        {
            return View();
        }

        public ActionResult EnterpriseArchitecture()
        {
            return View();
        }

        public ActionResult eCommerce()
        {
            return View();
        }

        public ActionResult eInvoicing()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult eTimeTracking()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Career()
        {
            return View();
        }

        public ActionResult Consulting()
        {
            return View();
        }

        public ActionResult Products()
        {
            return View();
        }

        public ActionResult PrivacyPolicy()
        {
            return View();
        }
    }
}