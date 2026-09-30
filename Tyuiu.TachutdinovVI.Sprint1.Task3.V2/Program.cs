using Tyuiu.TachutdinovVI.Sprint1.Task3.V2.Lib;
using System;

namespace Tyuiu.TachutdinovVI.Sprint1.Task3.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService calculator = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Калькулятор стоимости покупки                                           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Расчет стоимости тетрадей и                                             *");
            Console.WriteLine("* карандашей                                                              *");
            Console.WriteLine("* Результат округляется до 3 знаков                                       *");
            Console.WriteLine("* после запятой                                                           *");
            Console.WriteLine("***************************************************************************");

            try
            {
                Console.Write("Введите цену одной тетради: ");
                double notebookPrice = GetDoubleInput();

                Console.Write("Введите количество тетрадей: ");
                int notebookAmount = GetIntInput();

                Console.Write("Введите цену одного карандаша: ");
                double pencilPrice = GetDoubleInput();

                Console.Write("Введите количество карандашей: ");
                int pencilAmount = GetIntInput();

                double result = calculator.PurchaseAmount(notebookPrice, notebookAmount, pencilPrice, pencilAmount);

                Console.WriteLine("***********************************************************************");
                Console.WriteLine("* Результат                                                           *");
                Console.WriteLine("***********************************************************************");
                Console.WriteLine($"Тетради: {notebookPrice} руб. × {notebookAmount} шт.                  ");
                Console.WriteLine($"Карандаши: {pencilPrice} руб. × {pencilAmount} шт.                    ");
                Console.WriteLine($"Общая стоимость: {result} руб.                                        ");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.WriteLine("\nНажмите любую клавишу для завершения...                                  ");
            Console.ReadKey();
        }

        static double GetDoubleInput()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        static int GetIntInput()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
