using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.NosovaVD.Sprint3.Task2.V21.Lib;
namespace Tyuiu.NosovaVD.Sprint3.Task2.V21
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Носова В.Д. | ПКТб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Цикл do...while                                                   *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Носова Валерия Дмитриевна | ПКТб-23-2                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу используя цикл do...while, которая вычисляет сумму   *");
            Console.WriteLine("* ряда по формуле, при х = 1,5                                            *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double value = 1.5;
            int startValue = 1;
            int stopValue = 10; 
            Console.WriteLine("Значение X: " + value);
            Console.WriteLine("Стартовое значение цикла: " + startValue);
            Console.WriteLine("Конечное значение цикла: " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetSumSeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}
