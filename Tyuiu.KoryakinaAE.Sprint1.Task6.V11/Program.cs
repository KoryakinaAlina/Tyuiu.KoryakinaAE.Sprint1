using Tyuiu.KoryakinaAE.Sprint1.Task6.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Корякина А. Э. | ИСТНб-25-1";
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт #1                                                              *");
        Console.WriteLine("* Тема: Работа со строками класс Convert                                 *");
        Console.WriteLine("* Задание #6                                                             *");
        Console.WriteLine("* Вариант #11                                                            *");
        Console.WriteLine("* Выполнил: Корякина Алина Эльдаяговна | ИСТНб-25-1                      *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                               *");
        Console.WriteLine("* Написать программу: пользователь вводит текст.                         *");
        Console.WriteLine("* Проверить, что первая буква строки входит в нее еще раз.               *");
        Console.WriteLine("*                                                                        *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("**************************************************************************");

        string s = Console.ReadLine();
     
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");

        bool res = ds.CheckeFirstLetterRepetition(s);

        Console.WriteLine(res);
        Console.ReadKey();
    }
}