using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.VoytovichKA.Sprint1.Task0.V14.Lib
{
    public class DataService : ISprint2Task0V14
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];
            res[0] = x==321+y;
            res[1] = x/5*4!=y+106; 
            res[2] = x-1000<y; 
            res[3] = 2*x>y+5000; 
            res[4] = x<=y*5; 
            res[5] = 5*x>=y*y;
            return res;
        }
    }
}
