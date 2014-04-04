using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lecture05.Models;
using Lecture05.Controllers;
using System.Web.Mvc;

namespace Lecture05.Tests
{

    class TestDataBase : IDataBase
    {
        public IEnumerable<Department> GetDepartments()
        {
            return new List<Department>
            {
                new Department() { Name="a" },
                new Department() { Name="b" },
                new Department() { Name="ab"}
            };
        }
    }

    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var db = new TestDataBase();
            var index = new TestableController(db);
            var viewResult = index.Index("a");
            Assert.IsInstanceOfType(viewResult, typeof(ViewResult));
            var view = viewResult as ViewResult;
            Assert.IsInstanceOfType(view.Model,typeof(IEnumerable<Department>));
            var model = view.Model as IEnumerable<Department>;
            var list = model.ToArray();
            Assert.AreEqual(2, list.Length);
            Assert.AreEqual("a", list[0].Name);
            Assert.AreEqual("ab", list[1].Name);
        }
    }
}
