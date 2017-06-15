using AngularJSPrepareOstersund.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AngularJSPrepareOstersund.Controllers
{
    public class ValuesController : ApiController
    {
        private static List<Person> persons =
            new List<Person>() { 
                new Person{Name="Lisa", Age=44},
                new Person{Name="Gösta", Age=24},
                new Person{Name="Sara", Age=19},
                new Person{Name="Annmarie", Age=55},
                new Person{Name="Leffe", Age=14}
            }; 
        
        // GET api/values
        public IEnumerable<Person> Get()
        {
            return persons;
        }
        /*
         public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

         */
        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post(Person value)
        {
            persons.Add(value);
        }
        /*
           // POST api/values
        public void Post([FromBody]string value)
        {
            int test = value.Length;
        }
         
         */

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
