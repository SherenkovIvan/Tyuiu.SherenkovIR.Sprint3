using Tyuiu.SherenkovIR.Sprint3.Task0.V13.Lib;
namespace Tyuiu.SherenkovIR.Sprint3.Task0.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSeries()
        {
            DataService ds = new DataService();
            double value = 0.5;
            int startValue = 1;
            int stopValue = 20;

            double res = ds.GetSumSeries(value, startValue, stopValue);

            double wait = 0.2981987837906575;
            Assert.AreEqual(res, wait);
        }
    }
}
