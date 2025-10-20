using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SherenkovIR.Sprint3.Task4.V10.Lib
{
    public class DataService : ISprint3Task4V10
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }
                else
                {
                    double y = (Math.Sin(x) - x) / x;
                }


            }
            return Math.Round(res, 3);
        }
    }
}