using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi_Test.Models
{
    public class Person
    {
        public int PersonID { get; set; }
        public string Name { get; set; }
        //public Nullable<int> Telephone { get; set; }     
        public string Telephone { get; set; }
        public string NICNo { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}