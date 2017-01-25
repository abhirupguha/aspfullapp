using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataLayer;

namespace TestACS
{
    [TestClass]
    public class TestACSSampleApp
    {
        [TestMethod]
        public void TestGetPersons()
        {
            DAL dal = new DAL();
            dal.GetPersons();
        }

        [TestMethod]
        public void TestGetDepartments()
        {
            DAL dal = new DAL();
            dal.GetDepartments();
        }
    }
}
