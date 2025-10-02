using Tyuiu.KoryakinaAE.Sprint1.Task5.V4.Lib;

namespace Tyuiu.KoryakinaAE.Sprint1.Task5.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x = 13257;
            DataService ds = new DataService();
            int res = Convert.ToInt32(x);
            int result = ds.SecondsToHours(res);

            Assert.AreEqual(3, result);
        }
    }
}
