using Tyuiu.VoytovichKA.Sprint2.Task2.V19.Lib;

namespace Tyuiu.VoytovichKA.Sprint2.Task2.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void IsValid()
        {
            DataService ds = new DataService();
            int x=6,y=7;
            bool res = ds.CheckDotInShadedArea(x,y);
            Assert.AreEqual(res,true);
            x = 2;
            res = ds.CheckDotInShadedArea(x, y);
            Assert.AreNotEqual(res, true);
        }
    }
}
