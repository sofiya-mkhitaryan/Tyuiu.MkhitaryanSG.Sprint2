//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность операций не должна нарушаться)
//и арифметических выражений, которая вернет логическую последовательность(массив): (True, False, True, False, True, False), при x = 185, y = 251
using Tyuiu.MkhitaryanSG.Sprint2.Task0.V8.Lib;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнила: Мхитарян С. Г. | РППб-25-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #2                                                                 *");
        Console.WriteLine("* Тема: Операции сравнения                                                  *");
        Console.WriteLine("* Задание #0                                                                *");
        Console.WriteLine("* Вариант #8                                                                *");
        Console.WriteLine("* Выполнила: Мхитарян София Геворковна | РППб-25-1                          *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("* Написать программу из операций сравнений                                  *");
        Console.WriteLine("* (True, False, True, False, True, False), при x = 185, y = 251             *");
        Console.WriteLine("*****************************************************************************");


        DataService ds = new DataService();
        int x = 185;
        int y = 251;
        bool[] res = new bool[6];
        res = ds.GetCompareOperations(x, y);

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                           *");
        Console.WriteLine("*****************************************************************************");

        Console.WriteLine("Х = " + x);
        Console.WriteLine("Y = " + y);


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        for (int i = 0; i < 6; i++)

        {
            Console.WriteLine(res[i]);
        }
        Console.ReadKey();
    }

}