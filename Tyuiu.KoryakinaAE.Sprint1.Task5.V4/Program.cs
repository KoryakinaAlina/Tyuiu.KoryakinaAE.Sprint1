using System.Runtime.InteropServices;

using Tyuiu.KoryakinaAE.Sprint1.Task5.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Корякина А. Э. | ИСТНб-25-1";
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #1                                                              *");
        Console.WriteLine("* Тема: Преобразование типов и класс Convert                             *");
        Console.WriteLine("* Задание #5                                                             *");
        Console.WriteLine("* Вариант #4                                                             *");
        Console.WriteLine("* Выполнил: Корякина Алина Эльдаяговна | ИСТНб-25-1                       *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                               *");
        Console.WriteLine("* Написать программу, которая решает следующую задачу: Идет k-я секунда  *");
        Console.WriteLine("* суток. Определить, сколько полных часов прошло к этому моменту.        *");
        Console.WriteLine("*                                                                        *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");

        int k;
        Console.WriteLine("Введите секунды:");
        k = (int)Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("Количество полных часов = " + ds.SecondsToHours(k));
        Console.ReadLine();
    }
}