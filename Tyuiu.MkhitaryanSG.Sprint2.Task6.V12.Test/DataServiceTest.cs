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

            Assert.AreEqual("08.09.2023", ds.FindDateOfPreviousDay(2023, 9, 9));
            Assert.AreEqual("30.09.2023", ds.FindDateOfPreviousDay(2023, 10, 1));
            Assert.AreEqual("31.01.2023", ds.FindDateOfPreviousDay(2023, 2, 1));
            Assert.AreEqual("31.12.2022", ds.FindDateOfPreviousDay(2023, 1, 1));

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ds.FindDateOfPreviousDay(2023, 0, 15));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ds.FindDateOfPreviousDay(2023, 13, 15));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ds.FindDateOfPreviousDay(2023, 2, 30));
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => ds.FindDateOfPreviousDay(2023, 4, 31));
        }
    }
}
