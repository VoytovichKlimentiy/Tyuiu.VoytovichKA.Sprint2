using System.ComponentModel.Design;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.VoytovichKA.Sprint2.Task3.V2.Lib
{
    public class DataService : ISprint2Task3V2
    {
        public double Calculate(double x)
        {
            double res = new double();
            if (x < 1)
            {
                if (x < -6) { res = (x + 10 * x - (1 / (Math.Pow(x, 4)))); }
                else { res = Math.Pow(x, 5) + 10 * x - (1 / (Math.Sqrt(x + 3))); }
            }
            else if (x == 2) { res = x - (1 / x); }
            else if (x > 3) { res = x - 12 * x + Math.Cos(x); }
            return Math.Round(res,3);
        }
    }
}
