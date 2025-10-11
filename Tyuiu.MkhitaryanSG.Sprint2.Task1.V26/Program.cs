//Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать, но использовать один раз в выражении)
//и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться),
//а также арифметических выражений, которая вернет логическую последовательность(массив):
//(True, True, True, False, True, False), при a = 654, b = 671, c = 874, d = 137
using Tyuiu.MkhitaryanSG.Sprint2.Task1.V26.Lib;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнила: Мхитарян С. Г. | РППб-25-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #2                                                                 *");
        Console.WriteLine("* Тема: Логические операции                                                 *");
        Console.WriteLine("* Задание #1                                                                *");
        Console.WriteLine("* Вариант #26                                                                *");
        Console.WriteLine("* Выполнила: Мхитарян София Геворковна | РППб-25-1                          *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("* Написать программу из операций сравнений                                  *");
        Console.WriteLine("* и логических операций (|, &, ||, &&, !, ^)                                *");
        Console.WriteLine("* (True, True, True, False, True, False) a = 654, b = 671, c = 874, d = 137 *");
        Console.WriteLine("*****************************************************************************");


        DataService ds = new DataService();
        int a = 654;
        int b = 671;
        int c = 874;
        int d = 137;
        bool[] res = new bool[6];
        res = ds.GetLogicOperations(a, b, c, d);

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                           *");
        Console.WriteLine("*****************************************************************************");

        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);
        Console.WriteLine("c = " + c);
        Console.WriteLine("d = " + d);


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