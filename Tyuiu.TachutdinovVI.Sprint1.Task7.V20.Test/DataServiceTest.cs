using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.TachutdinovVI.Sprint1.Task7.V20.Lib;

namespace Tyuiu.TachutdinovVI.Sprint1.Task7.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1, y = 2;
            var n = ds.Calculate(x, y);
            Assert.AreEqual(4.129, n);

        }
    }
}