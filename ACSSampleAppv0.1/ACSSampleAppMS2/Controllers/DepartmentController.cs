using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ACSSampleAppMS2.Controllers
{
    public class DepartmentController : ApiController
    {
        public IEnumerable<string> GetDepartments()
        {
            return new List<string> { "Dept1", "Dept2", "Dept33" };
        }
    }
}
