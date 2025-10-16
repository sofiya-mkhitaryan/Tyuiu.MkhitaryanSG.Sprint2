//Написать программу, которая использует сокращенную форму записи оператора switch вычисляет требуемое значение и возвращает результат.
//Условие: Дата некоторого дня характеризуется тремя натуральными числами: g(год), m(порядковый номер месяца) и n(число).
//По заданным g, n и m определить дату предыдущего дня. Заданный год является високосным
using Tyuiu.MkhitaryanSG.Sprint2.Task6.V12.Lib;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнила: Мхитарян С. Г. | РППб-25-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #2                                                                 *");
        Console.WriteLine("* Тема: Получение результата из switch                                      *");
        Console.WriteLine("* Задание #6                                                                *");
        Console.WriteLine("* Вариант #12                                                               *");
        Console.WriteLine("* Выполнила: Мхитарян София Геворковна | РППб-25-1                          *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("* Написать программу, которая использует сокращенную форму записи оператора *");
        Console.WriteLine("* switch вычисляет требуемое значение и возвращает результат.               *");
        Console.WriteLine("* По заданным g, n и m определить дату предыдущего дня. Год високосный      *");
        Console.WriteLine("*****************************************************************************");

        DataService ds = new DataService();
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                           *");
        Console.WriteLine("*****************************************************************************");

        Console.WriteLine("Введите год:");
        int g = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите число (1-31):");
        int d = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите номер месяца (1-12):");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        string previousDate = ds.FindDateOfPreviousDay(g, m, d);

        Console.WriteLine($"Предыдущий день: {previousDate}");

        Console.ReadKey();
    }
}