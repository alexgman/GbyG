using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GbyG.Models
{
    public class SamplesByStatusUser
    {
        public Sample Sample { get; set; }
        public string Status { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}