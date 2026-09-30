using Tyuiu.TachutdinovVI.Sprint1.Task6.V8.Lib;
namespace Tyuiu.TachutdinovVI.Sprint1.Task6.V8.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "Привет";
            DataService ds = new DataService();
            string res = ds.MoveLetterToEnd(strTest);
            string wait = "риветП";
            Assert.AreEqual(wait, res);
        }
    }
}