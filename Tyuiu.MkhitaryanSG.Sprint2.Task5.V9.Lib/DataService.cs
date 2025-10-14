using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MkhitaryanSG.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        // Метод для определения, является ли год високосным
        private bool IsLeapYear(int y)
        {
            return (y % 4 == 0 && y % 100 != 0) || (y % 400 == 0);
        }

        // Метод для получения количества дней в месяце с использованием switch case
        private int GetDaysInMonth(int m, int y)
        {
            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return IsLeapYear(y) ? 29 : 28;
                default:
                    throw new ArgumentOutOfRangeException(nameof(m), "Месяц должен быть в диапазоне от 1 до 12.");
            }
        }

        public string FindDateOfNextDay(int m, int d)
        {
            // Предположим, что текущий год — 2023 (можно изменить на любой другой)
            int year = 2023;

            // Проверка корректности месяца
            if (m < 1 || m > 12)
                throw new ArgumentOutOfRangeException(nameof(m), "Месяц должен быть в диапазоне от 1 до 12.");

            // Проверка корректности дня
            int daysInCurrentMonth = GetDaysInMonth(m, year);
            if (d < 1 || d > daysInCurrentMonth)
                throw new ArgumentOutOfRangeException(nameof(d), "Неверный день для указанного месяца.");

            // Определяем следующий день
            if (d < daysInCurrentMonth)
            {
                return $"{d + 1} {m}"; // Просто увеличиваем день
            }
            else
            {
                // Переход на следующий месяц
                if (m == 12)
                {
                    return $"1 1"; // Переход на следующий год (год не выводится)
                }
                else
                {
                    return $"1 {m + 1}"; // Переход на следующий месяц
                }
            }
        }
    }
}
