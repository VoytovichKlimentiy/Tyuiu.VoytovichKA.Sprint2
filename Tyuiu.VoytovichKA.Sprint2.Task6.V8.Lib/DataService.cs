using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.VoytovichKA.Sprint2.Task6.V8.Lib
{
    public class DataService : ISprint2Task6V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {

            if (m == 1)
            {
                switch (n)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        n--; m = 31; break;
                    case 2:
                        n--; m = 28; break;
                    default:
                        n--; m = 30; break;
                }
            }
            else
            {
                m--;
            }
            string res = Convert.ToString(n) + "." + Convert.ToDouble(m);
            return res;
        }
    }
}
