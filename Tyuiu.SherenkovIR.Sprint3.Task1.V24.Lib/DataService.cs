using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SherenkovIR.Sprint3.Task1.V24.Lib
{
    public class DataService : ISprint3Task1V24
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double sumSeries = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
              
                double denominator = 6 + Math.Pow(value, i);
                double fraction = 2.0 / denominator;
                double term = Math.Pow(fraction, i); 
                sumSeries += term;
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
