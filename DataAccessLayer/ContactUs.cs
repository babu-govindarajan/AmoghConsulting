using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ContactUs
    {
        public int ContactUsId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool ItConsulting { get; set; }
        public bool Solutions { get; set; }
        public bool Training { get; set; }
        public string Message { get; set; }
        public string Response { get; set; }
    }
}
