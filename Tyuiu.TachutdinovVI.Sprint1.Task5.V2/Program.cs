using Tyuiu.TachutdinovVI.Sprint1.Task5.V2.Lib;

// ЗАДАНИЕ:
// Найти частное между квадратом Х и его корнем. Ответ привести к целому с помощью класса Convert.

namespace Tyuiu.TachutdinovVI.Sprint1.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                   *");
            Console.WriteLine("**************************************************************************************");



            Console.WriteLine("Введите значение х:                                                                   ");
            double temp = Convert.ToDouble(Console.ReadLine());



            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                         *");
            Console.WriteLine("**************************************************************************************");


            int res = Convert.ToInt32(ds.FahrenheitToСelsius(temp));
            Console.WriteLine(res);


            Console.ReadKey();

        }
    }
}