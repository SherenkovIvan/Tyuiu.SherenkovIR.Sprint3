﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.SherenkovIR.Sprint3.Task2.V27.Lib
{
    public class DataService : ISprint3Task2V27
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double SumSeries = 0;
            int i = startValue;

            do
            {
                double denominator = Math.Pow(1 + Math.Pow(value, i), i); 
                double term = 4.0 / denominator;
                SumSeries += term;
                i++;
            } while (i <= stopValue);
            return Math.Round(SumSeries, 2);
        }
    }
}
