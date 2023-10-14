using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DudkovIE.Sprint2.Task0.V29.Lib;
namespace Tyuiu.DudkovIE.Sprint2.Task0.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            bool[] res = new bool[6];
            bool[] wait = new bool[] {false, false, true, true, false, false};

            res = ds.GetCompareOperations(105, 735);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
