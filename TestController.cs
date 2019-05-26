using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_Test.Models;
using WebApi_Test.BusinessLayer;

namespace WebApi_Test.Controllers
{
    [Route("api/Test")]
    public class TestController : ApiController
    {
        private IRepository repo;

        public TestController(IRepository repo)
        {
            this.repo = repo;
        }


         [HttpGet, Route("Person")]
        public IEnumerable<Person> GetPerson()
        {
            return this.repo.GetPerson();
        }

        [HttpPost]
        public int CreatePerson(Person person)
        {
            return this.repo.CreatePerson(person);
        }

        [HttpPut]
        public int UpdatePerson(Person p)
        {
            try
            {
                return this.repo.UpdatePerson(p);
            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

        [HttpDelete]
        public int DeletePerson(int PersonID)
        {
            return this.repo.DeletePerson(PersonID);
        }

    }
}
