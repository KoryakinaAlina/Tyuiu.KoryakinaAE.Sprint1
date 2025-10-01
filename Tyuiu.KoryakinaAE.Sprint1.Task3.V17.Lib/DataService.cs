using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KoryakinaAE.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {
        public bool ZeroCheck(double number)
        {
            int Match = (int)(number * 1000);
            int Part = Match % 1000;
            for (int i = 0; i < 3; i++)
            {
                if (Part % 10 == 0)
                {
                    return true;
                }
                Part /= 10;
            }
            return false;  
        }
    }
}
