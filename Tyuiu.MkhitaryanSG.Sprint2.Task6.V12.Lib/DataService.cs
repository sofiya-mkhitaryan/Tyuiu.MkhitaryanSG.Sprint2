using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MkhitaryanSG.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12
    {
        public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int daysInMonth = m switch
            {
                1 => 31,
                2 => 29,  
                3 => 31,
                4 => 30,
                5 => 31,
                6 => 30,
                7 => 31,
                8 => 31,
                9 => 30,
                10 => 31,
                11 => 30,
                12 => 31,
                _ => throw new ArgumentOutOfRangeException("Месяц должен быть от 1 до 12.")
            };

            if (n < 1 || n > daysInMonth)
                throw new ArgumentOutOfRangeException("Неверный день для указанного месяца");

            int prevDay = n - 1;
            int prevMonth = m;
            int prevYear = g;

            if (prevDay == 0) // если число стало 0, значит нужно перейти к предыдущему месяцу
            {
                prevMonth = m - 1;
                if (prevMonth == 0) // если месяц стал 0, меняем на 12 и год уменьшаем
                {
                    prevMonth = 12;
                    prevYear = g - 1;
                }

                // заново узнаем количество дней в предыдущем месяце
                daysInMonth = prevMonth switch
                {
                    1 => 31,
                    2 => 29,
                    3 => 31,
                    4 => 30,
                    5 => 31,
                    6 => 30,
                    7 => 31,
                    8 => 31,
                    9 => 30,
                    10 => 31,
                    11 => 30,
                    12 => 31,
                    _ => throw new ArgumentOutOfRangeException("Месяц должен быть от 1 до 12.")
                };

                prevDay = daysInMonth; // последнее число предыдущего месяца
            }

            // формируем строку даты в формате "год.месяц.день"
            return prevYear + "." + prevMonth.ToString("D2") + "." + prevDay.ToString("D2");
        }
    }
}
