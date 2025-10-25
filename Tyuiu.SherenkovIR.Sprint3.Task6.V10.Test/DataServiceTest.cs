using Tyuiu.SherenkovIR.Sprint3.Task6.V10.Lib;
namespace Tyuiu.SherenkovIR.Sprint3.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int stertValue = 20;
            int stopValue = 32;

            int res = ds.GetSumTheDivisors(stertValue, stopValue);

            int wait = 396;
            Assert.AreEqual(res, wait);

        }
    }
}
