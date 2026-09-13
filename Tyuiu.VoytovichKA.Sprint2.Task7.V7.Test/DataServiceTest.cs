using Tyuiu.VoytovichKA.Sprint2.Task7.V7.Lib;

namespace Tyuiu.VoytovichKA.Sprint2.Task7.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void IsValid()
        {
            DataService ds = new DataService();
            double x = 0.5, y = 0.5;
            bool res=ds.CheckDotInShadedArea(x, y);
            Assert.IsTrue(res);
        }
    }
}
