using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Library;

namespace TestProject
{
    [TestClass]
    public class S03
    {

        [TestMethod]
        public void FunctionalTest()
        {
            var rnd = new Random(1);
            for (int i = 0; i < 100; i++)
            {
                var a = rnd.NextDouble() * 10;
                var b = rnd.NextDouble() * 10;
                var c = rnd.NextDouble() * 10;
                var solution = QuadricEquation.Solve(a, b, c);
                for (int j = 0; j < solution.Length; j++)
                {
                    Assert.AreEqual(0, a * solution[j] * solution[j] +
                        b * solution[j] + c, 10e-6);
                }
            }
        }
    }
}
