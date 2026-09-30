using Tyuiu.TachutdinovVI.Sprint1.Task1.V10.Lib;


namespace Tyuiu.TachutdinovVI.Sprint1.Task1.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double x = 1.0;
            double y = 3.0;

            var res = ds.Calculate(x, y);

            Assert.AreEqual(2, res);
        }
    }
}