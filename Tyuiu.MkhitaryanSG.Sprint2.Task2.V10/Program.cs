using Tyuiu.MkhitaryanSG.Sprint2.Task2.V10.Lib;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнила: Мхитарян С. Г. | РППб-25-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #2                                                                 *");
        Console.WriteLine("* Тема: Оператор if – полная и короткая форма записи                        *");
        Console.WriteLine("* Задание #2                                                                *");
        Console.WriteLine("* Вариант #10                                                               *");
        Console.WriteLine("* Выполнила: Мхитарян София Геворковна | РППб-25-1                          *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("* Написать программу на, которая запрашивает целые значения с клавиатуры    *");
        Console.WriteLine("* и вычисляет находится ли точка с координатами X,Y в заштрихованной области*");
        Console.WriteLine("*****************************************************************************");

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                           *");
        Console.WriteLine("*****************************************************************************");

        Console.WriteLine("Введите значение переменной Х: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение переменной Y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        DataService ds = new DataService();
        bool res = ds.CheckDotInShadedArea(x, y);


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        if (res)
        {
            Console.WriteLine("Точка находится в заштрихованной области");
        }

        else
        {
            Console.WriteLine("Точка не находится в заштрихованной области");
        }
        Console.ReadKey();
    }

}