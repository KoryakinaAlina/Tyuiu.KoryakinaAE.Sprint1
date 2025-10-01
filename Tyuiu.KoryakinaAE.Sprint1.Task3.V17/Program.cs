using Tyuiu.KoryakinaAE.Sprint1.Task3.V17.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();


        Console.Title = "Спринт #1 | Выполнил: Корякина А. Э.  | ИСТНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #17                                                             *");
        Console.WriteLine("* Выполнил: Корякина Алина Эльдаяговна | ИСТНб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая определяет, есть ли среди первых            *");
        Console.WriteLine("* трех цифр из дробной части заданного вещественного числа цифра 0.       *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        double x;

        Console.WriteLine("Число с дробной частью вещественного числа:");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Есть ли среди первых трех цифр из дробной части заданного вещественного числа цифра 0 - " + ds.ZeroCheck(x));

        Console.ReadLine();  
    }
}