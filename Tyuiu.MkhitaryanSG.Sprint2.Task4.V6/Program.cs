//Написать программу, которая вычисляет требуемое значение с использованием тернарного оператора, где пользователь вводит значение переменных x, y
//с клавиатуры, если x + 20 > y * 2, то z = x*((y+1)/(x+2))^x иначе y^2 + 2*x + (6/x). Окр до 3 знаков
using Tyuiu.MkhitaryanSG.Sprint2.Task4.V6.Lib;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнила: Мхитарян С. Г. | РППб-25-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #4                                                                 *");
        Console.WriteLine("* Тема: Тернарный оператор                                                  *");
        Console.WriteLine("* Задание #3                                                                *");
        Console.WriteLine("* Вариант #4                                                                *");
        Console.WriteLine("* Выполнила: Мхитарян София Геворковна | РППб-25-1                          *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение                  *");
        Console.WriteLine("* с использованием тернарного оператора                                     *");
        Console.WriteLine("* если x + 20 > y * 2, то z = x*((y+1)/(x+2))^x иначе y^2 + 2*x + (6/x)     *");
        Console.WriteLine("*****************************************************************************");

        DataService ds = new DataService();
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                           *");
        Console.WriteLine("*****************************************************************************");

        Console.WriteLine("Введите значение переменной Х: ");
        double x = Convert.ToDouble(Console.ReadLine());
        

        Console.WriteLine("Введите значение переменной Y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        double res = ds.Calculate(x, y);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Значение функции = " + res);

        Console.ReadKey();
    }

}