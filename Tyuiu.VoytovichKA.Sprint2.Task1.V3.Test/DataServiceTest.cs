using Tyuiu.VoytovichKA.Sprint2.Task1.V3.Lib;

namespace Tyuiu.VoytovichKA.Sprint2.Task1.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void IsValid()
        {
            DataService ds = new DataService();
            int a=185,b=316,c=134,d=134;
            bool[] test = new bool[6] { true, false, false, false, false, false };
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            CollectionAssert.AreEqual(test, res);
        }
    }
}
