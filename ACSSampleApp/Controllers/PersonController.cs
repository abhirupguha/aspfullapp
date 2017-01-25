using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ACSSampleApp.Controllers
{
    public class PersonController : ApiController
    {
        public IEnumerable<string>  GetPersons()
        {
            return new List<string> { "Name1", "Name2", "Name3" };
        }
    }
}
