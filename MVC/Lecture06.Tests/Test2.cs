using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Lecture05.Models;
using Lecture05.Controllers;
using System.Web.Mvc;

namespace Lecture05.Tests
{
    [TestClass]
    public class Test2
    {
        [TestMethod]
        public void TestMethod1()
        {
            var db = new Mock<IDataBase>();
            db
                .Setup(z => z.GetDepartments())
                .Returns(new List<Department>
                {
                    new Department { Name="a" },
                    new Department { Name="b" },
                    new Department { Name="ab" }
                });

            var index = new TestableController(db.Object);
            var list = ((index.Index("a") as ViewResult).Model as IEnumerable<Department>).ToArray();
            Assert.AreEqual(2, list.Length);
            Assert.AreEqual("a", list[0].Name);
            Assert.AreEqual("ab", list[1].Name);
        }
    }
}
