using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TachutdinovVI.Sprint1.Task7.V20.Lib
{
    public class DataService : ISprint1Task7V20
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(((2 + Math.Pow(Math.Cos(x + y), 2)) / (1 + Math.Abs(x - ((3 * x) / (1 + x * x * y * y)))) + x * y), 3, MidpointRounding.AwayFromZero);
        }
    }
}