using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using ExecutiveBonusUI.Models;

namespace ExecutiveBonusUI.Controllers
{
    public class PersonController : ApiController
    {
        public IHttpActionResult Get()
        {
            DateTime d1 = DateTime.Now;
            List<Person> persons = new List<Person>()
            {
                new Person {ID=1,FirstName="Craig", LastName="Playstead",  Address="Dumaguete City", Date = d1},
                new Person {ID=2,FirstName="Mark", LastName="javier",  Address="Dumaguete City",Date = d1},
                new Person {ID=3,FirstName="juan", LastName="del cruz",  Address="Makati City",Date = d1},
                new Person {ID=4,FirstName="james", LastName="Playstead",  Address="Dumaguete City",Date = d1},
                new Person {ID=5,FirstName="mats", LastName="Javier",  Address="Dumaguete City",Date = d1},
                new Person {ID=6,FirstName="paul", LastName="Del cruz",  Address="Makati City",Date = d1},
            };

            return Ok(persons);
        }
    }
}