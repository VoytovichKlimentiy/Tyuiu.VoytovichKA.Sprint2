using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.VoytovichKA.Sprint2.Task5.V6.Lib
{
    public class DataService : ISprint2Task5V6

    {
        public string FindCardNameAndValue(int value1, int value2)
        {
            string name="";
            string value="";
            switch (value1)
            {
                case 1:
                    name = "пик";
                    break;
                case 2:
                    name = "треф";
                    break;
                case 3:
                    name = "бубен";
                    break;
                case 4:
                    name = "черв";
                    break;
            }
            switch (value2)
            {
                case 6:
                    value = "Шестёрка";
                    break;
                case 7:
                    value = "Семёрка";
                    break;
                case 8:
                    value = "Восьмёрка";
                    break;
                case 9:
                    value = "Девятка";
                    break;
                case 10:
                    value = "Десятка";
                    break;
                case 11:
                    value = "Валет";
                    break;
                case 12:
                    value = "Дама";
                    break;
                case 13:
                    value = "Король";
                    break;
                case 14:
                    value = "Туз";
                    break;

            }
            return (value + " " + name);
        }
    }
}
