using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;

namespace TestProject
{
    [TestClass]
    public class S01
    {
        void Test(double A, double B, double C,
            int length, double x1, double x2)
        {
            var result = QuadricEquation.Solve(2, -4, -6);
            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(result[0], 3);
            Assert.AreEqual(result[1], -1);
        }

     
    }
}
