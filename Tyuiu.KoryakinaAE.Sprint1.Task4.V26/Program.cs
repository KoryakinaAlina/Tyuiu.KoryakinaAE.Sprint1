using Tyuiu.KoryakinaAE.Sprint1.Task4.V26.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1  | Выполнил: Корякина А.Э. | ИСТНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #26                                                              *");
        Console.WriteLine("* Выполнил: Корякина А.Э | ИСТНб-25-1                                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine();
        int x;
        Console.WriteLine("Введите значение Х:");
        x = Convert.ToInt32(Console.ReadLine());
        int y;
        Console.WriteLine("Введите значение Y:");
        y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("arctgx + y / e ^ y + x = " + ds.Calculate(x, y));
        Console.ReadKey();

    }
}