using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MkhitaryanSG.Sprint2.Task5.V9.Lib
{
    public class DataService : ISprint2Task5V9
    {
        public string FindDateOfNextDay(int m, int d)
        {
            int nextDay = d;
            int nextMonth = m;

            // Количество дней в каждом месяце
            int daysInMonth;

            switch (m)
            {
                case 1: 
                    daysInMonth = 31;
                    break;
                case 2: 
                    daysInMonth = 29; // или 29 при учёте високосного года
                    break;
                case 3:
                    daysInMonth = 31;
                    break;
                case 4:
                    daysInMonth = 30;
                    break;
                case 5:
                    daysInMonth = 31;
                    break;
                case 6:
                    daysInMonth = 30;
                    break;
                case 7:
                    daysInMonth = 31;
                    break;
                case 8:
                    daysInMonth = 31;
                    break;
                case 9:
                    daysInMonth = 30;
                    break;
                case 10:
                    daysInMonth = 31;
                    break;
                case 11:
                    daysInMonth = 30;
                    break;
                case 12:
                    daysInMonth = 31;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Месяц должен быть от 1 до 12.");
            }

            // Определяем следующий день
            if (d < daysInMonth)
            {
                nextDay++;
            }
            else if (d == daysInMonth)
            {
                nextDay = 1;
                nextMonth++;
                if (nextMonth > 12) // Если переходим на следующий год
                {
                    nextMonth = 1; // Сброс на январь
                }
            }

            return $"{nextDay:D2}.{nextMonth:D2}";
        }
    }
}
