using Tyuiu.KoryakinaAE.Sprint1.Task2.V7.Lib;

namespace Tyuiu.KoryakinaAE.Sprint1.Task2.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int r = 2;
            var res = Math.Round(ds.CalculateSquareCircle(r), 3);
            Assert.AreEqual(12.566, res);
        }
    }
}
