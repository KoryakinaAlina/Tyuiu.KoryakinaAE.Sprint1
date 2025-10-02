using Tyuiu.KoryakinaAE.Sprint1.Task6.V11.Lib;

namespace Tyuiu.KoryakinaAE.Sprint1.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string strTest = "sprinttasksix";
            bool wait = true;
            bool res = ds.CheckeFirstLetterRepetition(strTest);
            Assert.AreEqual(wait, res);
        }
    }
}
