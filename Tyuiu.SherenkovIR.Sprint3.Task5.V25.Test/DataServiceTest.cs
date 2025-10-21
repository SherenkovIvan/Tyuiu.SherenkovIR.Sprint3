using Tyuiu.SherenkovIR.Sprint3.Task5.V25.Lib;
namespace Tyuiu.SherenkovIR.Sprint3.Task5.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();
            int x = 2;
            int startValue1 = 1;
            int startValue2 = 3;
            int stopValue1 = 1;
            int stopValue2 = 10;

            double res = ds.GetSumSumSeries(x, startValue1, startValue2, stopValue1, stopValue2);

            double wait = 6133.748;

            Assert.AreEqual(wait, res);


        }
    }
}
