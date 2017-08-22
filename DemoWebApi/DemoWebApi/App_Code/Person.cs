using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.App_Code
{
    
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool IsActive { get; set; }
        public List<Phone> Phones { get; set; }
        public List<Email> Emails { get; set; }
    }

    public class Phone
    {
        public int ID { get; set; }
        public int PhoneNumber { get; set; }
    }

    public class Email
    {
        public int ID { get; set; }
        public string EmailAddress { get; set; }
    }

    
}