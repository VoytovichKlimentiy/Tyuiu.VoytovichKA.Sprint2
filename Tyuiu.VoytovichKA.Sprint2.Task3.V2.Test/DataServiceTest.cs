using Tyuiu.VoytovichKA.Sprint2.Task3.V2.Lib;

namespace Tyuiu.VoytovichKA.Sprint2.Task3.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void IsValid()
        {
            DataService ds = new DataService();
            double x = 4;
            double res = ds.Calculate(x);
            Assert.AreEqual(-44.654, res);
            x = -8;
            res= ds.Calculate(x);
            Assert.AreEqual(-88, res);
        }
    }
}
