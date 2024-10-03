using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GubanovaSO.Sprint1.Task2.V3.Lib
{
    public class DataService : ISprint1Task2V3
    {
        public int ConvertHourToMin(int value)
        {
            return Convert.ToInt32(value * 60);

        }
    }
}
