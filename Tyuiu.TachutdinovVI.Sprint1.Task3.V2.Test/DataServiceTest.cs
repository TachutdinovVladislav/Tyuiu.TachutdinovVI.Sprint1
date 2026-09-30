using Tyuiu.TachutdinovVI.Sprint1.Task3.V2.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.TachutdinovVI.Sprint1.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidPurchaseAmount()
        {
            DataService ds = new DataService();
            double priceNotebook = 100;
            int amountNotebook = 6;
            double pricePencil = 30;
            int amountPencil = 5;

            double expected = 750; // 100*6 + 30*5 = 600 + 150 = 750
            double result = ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ValidPurchaseAmountWithDecimals()
        {
            DataService ds = new DataService();
            double priceNotebook = 45.75;
            int amountNotebook = 3;
            double pricePencil = 12.50;
            int amountPencil = 4;

            double expected = 187.25; // 45.75*3 + 12.50*4 = 137.25 + 50 = 187.25
            double result = ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil);

            Assert.AreEqual(expected, result);
        }
    }
}