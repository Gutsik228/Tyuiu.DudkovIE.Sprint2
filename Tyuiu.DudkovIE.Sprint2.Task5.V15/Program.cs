using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DudkovIE.Sprint2.Task5.V15.Lib;
namespace Tyuiu.DudkovIE.Sprint2.Task5.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение переменной X");
            int x;
            x = Convert.ToInt32(Console.ReadLine());
            
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Дудков И.Е | СМАРТб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: 2.5 Оператор switchФайл                                           *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Дудков И.Е  | СМАРТб-23-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет день недели с помощью switch case   *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("X = " + x);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            var res = ds.FindDayName(x);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
