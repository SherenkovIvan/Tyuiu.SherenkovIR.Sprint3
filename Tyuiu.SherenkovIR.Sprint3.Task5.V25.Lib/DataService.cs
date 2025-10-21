﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SherenkovIR.Sprint3.Task5.V25.Lib
{
    public class DataService : ISprint3Task5V25
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumSeries = 0;

            for (int i = 1; i <= 3; i++)
            {
                for (int k = 1; k <= 10; k++)
                {
                    sumSeries = sumSeries += Math.Pow(x, k) + Math.Cos(k);
                }
            }

            return Math.Round(sumSeries, 3);
        }
    }
}
