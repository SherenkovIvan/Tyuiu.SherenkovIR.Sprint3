﻿using Tyuiu.SherenkovIR.Sprint3.Task4.V10.Lib;
namespace Tyuiu.SherenkovIR.Sprint3.Task4.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);

            double wait = 0.014;
            Assert.AreEqual(res, wait);

        }
    }
}
