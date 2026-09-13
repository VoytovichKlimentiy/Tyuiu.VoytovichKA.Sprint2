using Tyuiu.VoytovichKA.Sprint2.Task6.V8.Lib;

namespace Tyuiu.VoytovichKA.Sprint2.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void IsValid()
        {
            int n = 3, m = 13;
            DataService ds = new DataService();
            string res = ds.FindDateOfPreviousDay(m,n);
            Assert.AreEqual("12.03", res);
        }
    }
}
