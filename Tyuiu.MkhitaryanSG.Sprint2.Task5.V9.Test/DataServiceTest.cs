using Tyuiu.MkhitaryanSG.Sprint2.Task5.V9.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint2.Task5.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {

        [TestMethod]
        public void Test()
        {
            DataService ds = new DataService();

            // Тестирование перехода на следующий день
            Assert.AreEqual("1 3", ds.FindDateOfNextDay(28, 2)); // Следующий день после 28 февраля
            Assert.AreEqual("1 4", ds.FindDateOfNextDay(31, 3)); // Следующий день после 31 марта
            Assert.AreEqual("1 5", ds.FindDateOfNextDay(30, 4)); // Следующий день после 30 апреля
            Assert.AreEqual("1 6", ds.FindDateOfNextDay(31, 5)); // Следующий день после 31 мая
            Assert.AreEqual("1 1", ds.FindDateOfNextDay(31, 12)); // Следующий день после 31 декабря
            Assert.AreEqual("1 2", ds.FindDateOfNextDay(31, 1)); // Следующий день после 31 января

            // Тестирование исключений для неверных значений месяца
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ds.FindDateOfNextDay(0, 15), "Месяц должен быть в диапазоне от 1 до 12."); // Неверный месяц
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ds.FindDateOfNextDay(13, 15), "Месяц должен быть в диапазоне от 1 до 12."); // Неверный месяц

            // Тестирование исключений для неверных значений дня
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ds.FindDateOfNextDay(30, 2), "Неверный день для указанного месяца."); // Неверный день для февраля
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ds.FindDateOfNextDay(31, 4), "Неверный день для указанного месяца."); // Неверный день для апреля
        }
    }
}
