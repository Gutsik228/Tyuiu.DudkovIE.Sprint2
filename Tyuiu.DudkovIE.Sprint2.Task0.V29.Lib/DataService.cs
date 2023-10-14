using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DudkovIE.Sprint2.Task0.V29.Lib
{
    public class DataService : ISprint2Task0V29
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] bolean = new bool[6];
            bolean[0] = x == y;
            bolean[1] = x + 630 != y;
            bolean[2] = x < y;
            bolean[3] = x + 1000 > y;
            bolean[4] = x + 1000 <= y;
            bolean[5] = x >= y;

            return bolean;
        }
    }
}
