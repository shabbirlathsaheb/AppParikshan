using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;


namespace WebApplication1.Controllers
{
    [RoutePrefix("api/person")]
    public class PersonController : ApiController
    {
        List<Person> persons = new List<Person> {
                new Person{ DateOfBirth = new DateTime(1987, 04, 03),
                 Designation = "Developer", ID = 1, Name = "Shabbir", IsActive = true,
                Emails = new List<Email> { new Email { ID = 1, EmailAddress = "shabbir.husain.1987@gmail.com"
                }}, Phones = new List<Phone>{ new Phone { ID =1, PhoneNumber = 123456789 } }
                }
            };

        [Route("{id:int}")]
        [HttpGet]
        public async Task<IHttpActionResult> Get(int id)
        {
            return Ok(persons.FirstOrDefault(p=> p.ID == id));
        }
    }

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
