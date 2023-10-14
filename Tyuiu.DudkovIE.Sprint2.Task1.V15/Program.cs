using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DudkovIE.Sprint2.Task1.V15.Lib;
namespace Tyuiu.DudkovIE.Sprint2.Task1.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] res = new bool[6];

            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Дудков И. Е. | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема:2.1 Логические операции                                       *");
            Console.WriteLine("* Задание #1                                                             *");
            Console.WriteLine("* Вариант #15                                                              *");
            Console.WriteLine("* Выполнил: Дудков Игорь Евгеньевич | СМАРТб-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться),");
            Console.WriteLine("* (True, False, False, False, False, True), при a = 415, b = 616, c = 134, d = 127;");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(" a = 415, b = 616, c = 134, d = 127");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            res = ds.GetLogicOperations(415, 616, 134, 127);
            foreach (bool b in res)
            {
                Console.Write(b + " ");
            }


            Console.ReadKey();

        }
    }
}
