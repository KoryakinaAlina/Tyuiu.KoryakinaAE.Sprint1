using Tyuiu.KoryakinaAE.Sprint1.Task4.V26.Lib;
namespace Tyuiu.KoryakinaAE.Sprint1.Task4.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double wait = 0.105;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
