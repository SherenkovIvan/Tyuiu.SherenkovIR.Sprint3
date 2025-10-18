using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SherenkovIR.Sprint3.Task2.V27.Lib
{
    public class DataService : ISprint3Task2V27
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double SumSeries = 0;
            int i = 1;

            do
            {
                double term = 4.0 / (1 + Math.Pow(value, i));
                SumSeries += term;
                i++;
            } while (i <= 14);

            return Math.Round(SumSeries, 3);
        }
    }
}
