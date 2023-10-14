using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DudkovIE.Sprint2.Task1.V15.Lib;
namespace Tyuiu.DudkovIE.Sprint2.Task1.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            bool[] res = new bool[6];
            bool[] wait = new bool[] { true, false, false, false, false, true } ;

            res = ds.GetLogicOperations(415, 616, 134, 127);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
