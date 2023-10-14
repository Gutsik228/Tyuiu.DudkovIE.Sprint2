using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DudkovIE.Sprint2.Task0.V29.Lib;
namespace Tyuiu.DudkovIE.Sprint2.Task0.V29
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
            Console.WriteLine("* Тема: 2.0 Операции сравненияФайл                                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #29                                                              *");
            Console.WriteLine("* Выполнил: Дудков Игорь Евгеньевич | СМАРТб-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций ");
            Console.WriteLine("* не должна нарушаться) и арифметических выражений, которая вернет логическую последовательность(массив): ((False, False, True, True, False, False), при x = 105, y = 735");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("X = 105 , y  = 735");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            res = ds.GetCompareOperations(105, 735);
            foreach(bool b in res)
            {
                Console.Write(b + " ");
            }


            Console.ReadKey();
        }
    }
}
