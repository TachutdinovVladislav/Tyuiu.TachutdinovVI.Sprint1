using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TachutdinovVI.Sprint1.Task2.V12.Lib;

namespace Tyuiu.TachutdinovVI.Sprint1.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 10, b = 2, c = 4;
            var res = ds.CalculateParallelepipedVolume(a, b, c);
            Assert.AreEqual(80, res);
        }
    }
}