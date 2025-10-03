using Tyuiu.KoryakinaAE.Sprint1.Task7.V19.Lib;

namespace Tyuiu.KoryakinaAE.Sprint1.Task7.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            double x = 2;
            DataService ds = new DataService();
            double res = ds.Calculate(x);
            double wait = 15.409;
            Assert.AreEqual(wait, res);
        }
    }
}
