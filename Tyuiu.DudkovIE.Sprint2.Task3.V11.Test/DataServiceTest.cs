using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DudkovIE.Sprint2.Task3.V11.Lib;
namespace Tyuiu.DudkovIE.Sprint2.Task3.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double res = ds.Calculate(1);
            double wait = 1.824;
            Assert.AreEqual(wait, res, 0.001);
        }
    }
}
