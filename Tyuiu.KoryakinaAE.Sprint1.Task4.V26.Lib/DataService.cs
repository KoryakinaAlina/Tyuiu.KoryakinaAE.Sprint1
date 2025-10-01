using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KoryakinaAE.Sprint1.Task4.V26.Lib
{
    public class DataService : ISprint1Task4V26
    {
        public double Calculate(double x, double y)
        {
            var res = (Math.Atan(x) + y) / (Math.Exp(y + x));
            return Math.Round(res, 3);
        }
    }
}
