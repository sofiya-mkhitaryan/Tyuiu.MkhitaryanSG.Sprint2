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

            Assert.AreEqual("09.09", ds.FindDateOfNextDay(9, 8));
            Assert.AreEqual("01.10", ds.FindDateOfNextDay(9, 30));
            Assert.AreEqual("01.02", ds.FindDateOfNextDay(1, 31));
            Assert.AreEqual("01.03", ds.FindDateOfNextDay(2, 28)); // Не учитываем високосные года
            Assert.AreEqual("01.01", ds.FindDateOfNextDay(12, 31));

            // Тестирование исключений для неверных значений месяца
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ds.FindDateOfNextDay(0, 15), "Месяц должен быть в диапазоне от 1 до 12."); // Неверный месяц
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ds.FindDateOfNextDay(13, 15), "Месяц должен быть в диапазоне от 1 до 12."); // Неверный месяц

            // Тестирование исключений для неверных значений дня
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ds.FindDateOfNextDay(30, 2), "Неверный день для указанного месяца."); // Неверный день для февраля
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ds.FindDateOfNextDay(31, 4), "Неверный день для указанного месяца."); // Неверный день для апреля
        }
    }
}
