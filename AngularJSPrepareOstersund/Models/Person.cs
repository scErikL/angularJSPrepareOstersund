using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AngularJSPrepareOstersund.Models
{
    public class Person
    {
        /*[Key]
        public string SSN { get; set; }*/
        public string Name { get; set; }
        public int Age { get; set; }
    }
}