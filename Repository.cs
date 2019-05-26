using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi_Test.Models;

namespace WebApi_Test.BusinessLayer
{
    public class Repository : IRepository
    {
        private readonly TestPersonDBEntities context;
        public Repository()
        {
            context = new TestPersonDBEntities();
        }

        public IEnumerable<Person> GetPerson()
        {
            var result = context.usp_GetPerson(0).Select(p => new Person { PersonID = p.PersonID, Name = p.Name, Telephone = p.Telephone, NICNo = p.NICNo, Address = p.Address, Email = p.Email });
            return result;
        }

        //public Person GetPersonById(int PersonID)
        //{
        //    var r = context.usp_GetPersonById(PersonID).Select(p => new Person { PersonID = p.PersonID, Name = p.Name, Telephone = (int)p.Telephone, NICNo = p.NICNo, Address = p.Address, Email = p.Email });
        //    return r.FirstOrDefault();
        //}

        public int CreatePerson(Person p)
        {
            return context.usp_CreatePerson(p.Name, p.Telephone, p.NICNo, p.Address, p.Email);

        }

        public int UpdatePerson(Person p)
        {
            return context.usp_UpdatePerson(p.PersonID, p.Name, p.Telephone, p.NICNo, p.Address, p.Email);
        }

        public int DeletePerson(int PersonID)
        {
            return context.usp_DeletePerson(PersonID);
        }

        public IEnumerable<Department> GetDepartment()
        {
            var data = context.usp_GetDepartment().Select(p => new Department { DepartmentID = p.DepartmentID, DName = p.DName });
            return data;
        }



    }
}