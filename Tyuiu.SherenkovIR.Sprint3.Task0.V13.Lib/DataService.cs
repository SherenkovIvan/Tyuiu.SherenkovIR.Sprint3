using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SherenkovIR.Sprint3.Task0.V13.Lib
{
    public class DataService : ISprint3Task0V13
    {
        public double GetSumSeries(double a, int startValue, int stopValue)
        {
            double sumSeries = 0;

            for (int k = startValue; k <= stopValue; k++)
            {
                double term = (Math.Pow(a, k) + 0.5) * Math.Cos(k);
                sumSeries += term;
                
            }

             return Math.Round(sumSeries, 3);
        }
    }
}
