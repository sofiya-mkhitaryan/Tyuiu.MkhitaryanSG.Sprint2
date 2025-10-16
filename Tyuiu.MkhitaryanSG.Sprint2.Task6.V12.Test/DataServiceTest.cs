using Tyuiu.MkhitaryanSG.Sprint2.Task6.V12.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint2.Task6.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {

        [TestMethod]
        public void FindDateOfPreviousDay()
        {
            DataService ds = new DataService();

            Assert.AreEqual("2023.09.08", ds.FindDateOfPreviousDay(2023, 9, 9));
            Assert.AreEqual("2023.09.30", ds.FindDateOfPreviousDay(2023, 10, 1));
            Assert.AreEqual("2023.01.31", ds.FindDateOfPreviousDay(2023, 2, 1));
            Assert.AreEqual("2022.12.31", ds.FindDateOfPreviousDay(2023, 1, 1));

            // Тестирование исключений для неверных значений месяца
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ds.FindDateOfPreviousDay(2023, 0, 15), "Месяц должен быть в диапазоне от 1 до 12.");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ds.FindDateOfPreviousDay(2023, 13, 15), "Месяц должен быть в диапазоне от 1 до 12.");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ds.FindDateOfPreviousDay(2023, 30, 2), "Неверный день для указанного месяца.");
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ds.FindDateOfPreviousDay(2023, 31, 4), "Неверный день для указанного месяца.");
        }
    }
}
