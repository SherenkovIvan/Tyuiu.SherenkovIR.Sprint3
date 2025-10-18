﻿using Tyuiu.SherenkovIR.Sprint3.Task1.V24.Lib;
namespace Tyuiu.SherenkovIR.Sprint3.Task1.V24.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            int value = 5;
            int startValue = 1;
            int stopValue = 12;

            double res = ds.GetSumSeries(value, startValue, stopValue); 

            double wait = 0.186;
            Assert.AreEqual(wait, res);

        }
    }
}