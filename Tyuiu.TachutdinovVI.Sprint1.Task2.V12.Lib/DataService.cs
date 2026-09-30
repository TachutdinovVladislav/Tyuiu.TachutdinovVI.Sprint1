using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.TachutdinovVI.Sprint1.Task2.V12.Lib
{
    public class DataService : ISprint1Task2V12
    {
        public int CalculateParallelepipedVolume(int value, int valueTwo, int valueThree)
        {
            return value * valueTwo * valueThree;
        }
    }
}