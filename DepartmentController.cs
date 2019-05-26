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
    public class DepartmentController : ApiController
    {
         private IRepository repo;

         public DepartmentController(IRepository repo)
        {
            this.repo = repo;
        }

         [HttpGet]
         public IEnumerable<Department> GetDepartment()
         {
             return this.repo.GetDepartment();
         }
    }
}
