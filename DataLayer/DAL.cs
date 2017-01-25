using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DAL
    {
        public List<Person> GetPersons()
        {
            List<Person> persons = new List<Person>();
            using (testacsEntities1 dbContext = new testacsEntities1())
            {
                persons = (from p in dbContext.Persons
                           select p).ToList();
            }
            return persons;
        }

        public List<Department> GetDepartments()
        {
            List<Department> depts = new List<Department>();
            using (testacsEntities1 dbContext = new testacsEntities1())
            {
                depts = (from d in dbContext.Departments
                           select d).ToList();
            }
            return depts;
        }
    }
}
