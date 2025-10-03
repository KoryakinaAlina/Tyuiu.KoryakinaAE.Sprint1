using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KoryakinaAE.Sprint1.Task7.V19.Lib
{
    public class DataService : ISprint1Task7V19
    {
        public double Calculate(double x)
        {
            var x2 = Math.Pow(x, 2);
            var x3 = Math.Pow(x, 3);
            var x4 = Math.Pow(x, 4);
            var x5 = Math.Pow(x, 5);
            var z = x - ((7 * x2) / x3) + Math.Sin(x) + Math.Abs(x4 - x5);
            var res = Math.Round(z, 3);
            return res;
        }
    }
}
