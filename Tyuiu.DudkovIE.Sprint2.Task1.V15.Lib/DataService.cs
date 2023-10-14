using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.DudkovIE.Sprint2.Task1.V15.Lib
{
    public class DataService : ISprint2Task1V15
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] bolean = new bool[6];
            bolean[0] = (a == b) | (b > c);
            bolean[1] = (c != b) & (b < c);
            bolean[2] = (a == b) || (b < c);
            bolean[3] = (a == b) && (b < c);
            bolean[4] = !(a < b);
            bolean[5] = (a > b) ^ (b > c);

            return bolean;
        }
    }
}
