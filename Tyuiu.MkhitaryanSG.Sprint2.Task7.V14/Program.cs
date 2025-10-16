//Написать программу на C#, которая запрашивает исходные данные (вещественные значения) и вычисляет,
//находится ли точка с координатами X,Y в заштрихованной области.
using Tyuiu.MkhitaryanSG.Sprint2.Task7.V14.Lib;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнила: Мхитарян С. Г. | РППб-25-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #2                                                                 *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                   *");
        Console.WriteLine("* Задание #7                                                                *");
        Console.WriteLine("* Вариант #14                                                               *");
        Console.WriteLine("* Выполнила: Мхитарян София Геворковна | РППб-25-1                          *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные             *");
        Console.WriteLine("* (вещественные значения) и вычисляет,находится ли точка с                  *");
        Console.WriteLine("* координатами X,Y в заштрихованной области.                                *");
        Console.WriteLine("*****************************************************************************");

        DataService ds = new DataService();
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                           *");
        Console.WriteLine("*****************************************************************************");

        Console.WriteLine("Введите значение переменной Х: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите значение переменной Y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        bool res = ds.CheckDotInShadedArea(x, y);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        if (res)
        {
            Console.WriteLine("Точка находиться в заштрихованной области");
        }
        else
        {
            Console.WriteLine("Точка не находиться в заштрихованной области");
        }

            Console.ReadKey();
    }
}
