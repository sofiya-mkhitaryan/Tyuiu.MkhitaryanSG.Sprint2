using Tyuiu.MkhitaryanSG.Sprint2.Task6.V12.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint2.Task6.V12.Test
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
            Assert.AreEqual("01.01", ds.FindDateOfNextDay(12, 31));

            // Тестирование исключений для неверных значений месяца
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ds.FindDateOfNextDay(0, 15), "Месяц должен быть в диапазоне от 1 до 12.");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ds.FindDateOfNextDay(13, 15), "Месяц должен быть в диапазоне от 1 до 12.");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ds.FindDateOfNextDay(30, 2), "Неверный день для указанного месяца.");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ds.FindDateOfNextDay(31, 4), "Неверный день для указанного месяца.");
        }
    }
}
