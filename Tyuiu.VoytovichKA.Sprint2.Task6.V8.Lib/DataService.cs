using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.VoytovichKA.Sprint2.Task6.V8.Lib
{
    public class DataService : ISprint2Task6V8
    {
        public string FindDateOfPreviousDay(int m, int n)
        {

            switch (m)
            {
                case 1:
                    switch (n)
                    {
                        case 1:
                            break;
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
                    break;
                default:
                    m--;
                    break;
            }
            string res = null;
            if (n >= 1 && n <= 9)
            {
                res = Convert.ToString(m) + ".0" + n;
            }
            else
            {
                res = Convert.ToString(m) + "." + n;
            }
            return res;
        }
    }
}
