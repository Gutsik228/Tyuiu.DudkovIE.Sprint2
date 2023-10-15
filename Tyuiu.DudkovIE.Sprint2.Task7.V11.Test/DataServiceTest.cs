using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DudkovIE.Sprint2.Task7.V11.Lib;
namespace Tyuiu.DudkovIE.Sprint2.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            bool ans = ds.CheckDotInShadedArea(-0.5, -0.5);

            Assert.AreEqual(true, ans);
        }
    }
}
