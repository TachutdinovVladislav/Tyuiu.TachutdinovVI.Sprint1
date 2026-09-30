using Tyuiu.TachutdinovVI.Sprint1.Task5.V2.Lib;


namespace Tyuiu.TachutdinovVI.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double temp = 5;
            DataService ds = new DataService();
            double res = ds.FahrenheitToСelsius(temp);

            int result = Convert.ToInt32(res);

            int wait = -15;
            Assert.AreEqual(wait, result);
        }
    }
}