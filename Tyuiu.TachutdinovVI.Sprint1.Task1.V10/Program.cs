using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using Tyuiu.TachutdinovVI.Sprint1.Task1.V10.Lib;


class Program
{
    static void Main(string[] args)
    {

        DataService ds = new DataService();


        Console.Title = "Спринт #1 | Выполнил: Тачутдинов В. И. | ИСТНб-26-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #10                                                             *");
        Console.WriteLine("* Выполнил: Тачутдинов Владислав Ильдусович |  ИСТНб-26-1                 *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* вычисляет результат по формуле (x+y)/(1+x) и печатает его на экране.    *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");


        double x, y;

        Console.WriteLine("Введите значение X");
        x = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine("Введите значение Y");
        y = Convert.ToDouble(Console.ReadLine());



        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");


        Console.WriteLine(ds.Calculate(x, y));


        Console.ReadLine();







    }
}





