using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi_Test.Models;

namespace WebApi_Test.BusinessLayer
{
    public interface IRepository
    {
        IEnumerable<Person> GetPerson();
        int CreatePerson(Person p);
        int UpdatePerson(Person p);
        int DeletePerson(int PersonID);
      
        IEnumerable<Department> GetDepartment();
    }
}
