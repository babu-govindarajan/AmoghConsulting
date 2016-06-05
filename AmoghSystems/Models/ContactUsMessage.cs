using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace AmoghSystems.Models
{
    public class ContactUsMessage
    {
        public ContactUsMessage()
        {
        }

        public ContactUsMessage(string firstName, string lastName, string email, string phNumber, string message)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phNumber;
            Message = message;
        }

        [Required(ErrorMessage = "Please enter your First Name")]
        [DataType(DataType.Text)]
        [DisplayName("First Name")]
        public string FirstName
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Please enter your Last Name")]
        [DataType(DataType.Text)]
        [DisplayName("Last Name")]
        public string LastName
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Please enter valid EMail Id")]
        [RegularExpression("^([a-zA-Z0-9_\\-\\.]+)@[a-z0-9-]+(\\.[a-z0-9-]+)*(\\.[a-z]{2,3})$")]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email Address")]
        public string Email
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Please enter valid Phone Number")]        
        [DataType(DataType.Text)]
        [DisplayName("Phone Number")]
        public string PhoneNumber
        {
            get;
            set;
        }

        [DisplayName("IT Consulting")]        
        public bool ItConsulting
        {
            get; 
            set; 
        }

        [DisplayName("Solutions")]
        public bool Solutions
        {
            get; 
            set;
        }

        [DisplayName("Training")]
        public bool Training
        {
            get; 
            set;
        }

        [Required(ErrorMessage = "Message cannot be empty")]
        [DataType(DataType.MultilineText)]
        [DisplayName("Your Message")]
        public string Message
        {
            get;
            set;
        }
    }

    
}