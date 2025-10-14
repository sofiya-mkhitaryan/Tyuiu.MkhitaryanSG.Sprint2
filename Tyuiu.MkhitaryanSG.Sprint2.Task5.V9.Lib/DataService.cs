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
                case 1: // Январь
                case 3: // Март
                case 5: // Май
                case 7: // Июль
                case 8: // Август
                case 10: // Октябрь
                case 12: // Декабрь
                    daysInMonth = 31;
                    break;
                case 4: // Апрель
                case 6: // Июнь
                case 9: // Сентябрь
                case 11: // Ноябрь
                    daysInMonth = 30;
                    break;
                case 2: // Февраль
                    daysInMonth = 28; // Не учитываем високосные года
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Неверный номер месяца.");
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

            // Форматируем вывод в виде "DD.MM"
            return $"{nextDay:D2}.{nextMonth:D2}";
        }
    }
}
