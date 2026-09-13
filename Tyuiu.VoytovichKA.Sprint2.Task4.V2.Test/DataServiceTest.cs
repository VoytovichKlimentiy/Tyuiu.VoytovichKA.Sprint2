using Tyuiu.VoytovichKA.Sprint2.Task4.V2.Lib;

namespace Tyuiu.VoytovichKA.Sprint2.Task4.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void IsValid()
        {
            DataService ds = new DataService();
            double x = 8, y = 3;
            double res=ds.Calculate(x, y);
            Assert.AreEqual(res, 11);
        }
    }
}
