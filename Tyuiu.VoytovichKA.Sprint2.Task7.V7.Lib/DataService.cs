using System.Timers;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.VoytovichKA.Sprint2.Task7.V7.Lib
{
    public class DataService : ISprint2Task7V7
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (y < 2 && y > 0)
            {
                if (y < (2 - x * x) && x > -Math.Sqrt(2) && x < Math.Sqrt(2))
                    return true;
                else return false;
            }
            else if (y < 0 && y > -2)
            {
                if (y > x && y < (2 - x * x)) return true;
                else return false;
            }
            else
            {
                return false;
            }
        }
    }
}
