using Tyuiu.SherenkovIR.Sprint3.Task3.V22.Lib;
namespace Tyuiu.SherenkovIR.Sprint3.Task3.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidMaxCharCount()
        {
            DataService ds = new DataService();
            string str = "tbtbbb dsfbg bbg";
            char chr = 'b';

            int res = ds.GetMaxCharCount(str, chr);

            int wait = 3;

            Assert.AreEqual(wait, res);


        }
    }
}
