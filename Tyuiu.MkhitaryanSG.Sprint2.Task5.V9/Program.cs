//Написать программу, которая использует оператор switch вычисляет требуемое значение и возвращает результат.
//Условие: Дата некоторого дня характеризуется двумя натуральными числами: m(порядковый номер месяца) и n(число).
//По заданным n и m определить дату следующего дня (принять, что n и m не характеризуют 31 декабря).
using Tyuiu.MkhitaryanSG.Sprint2.Task5.V9.Lib;
class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Спринт #2 | Выполнила: Мхитарян С. Г. | РППб-25-1";

        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* Спринт #2                                                                 *");
        Console.WriteLine("* Тема: Тернарный оператор                                                  *");
        Console.WriteLine("* Задание #5                                                                *");
        Console.WriteLine("* Вариант #9                                                                *");
        Console.WriteLine("* Выполнила: Мхитарян София Геворковна | РППб-25-1                          *");
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                  *");
        Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет          *");
        Console.WriteLine("* требуемое значение и возвращает результат.                                *");
        Console.WriteLine("* определить дату следующего дня                                            *");
        Console.WriteLine("*****************************************************************************");

        DataService ds = new DataService();
        Console.WriteLine("*****************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ                                                           *");
        Console.WriteLine("*****************************************************************************");

        // Запрос у пользователя номера месяца и числа
        Console.WriteLine("Введите число:");
        int month = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите номер месяца (1-12):");
        int day = int.Parse(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        try
        {
            // Используем введенные пользователем значения для вычисления следующей даты
            string nextDate = ds.FindDateOfNextDay(day, month);
            Console.WriteLine(nextDate); // Выводим результат
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message); // Обработка исключений
        }

        Console.ReadKey();
    }
}