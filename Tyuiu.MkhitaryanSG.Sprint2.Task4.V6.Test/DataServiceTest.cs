//если x + 20 > y * 2, то z = x*((y+1)/(x+2))^x иначе y^2 + 2*x + (6/x)
using Tyuiu.MkhitaryanSG.Sprint2.Task4.V6.Lib;
namespace Tyuiu.MkhitaryanSG.Sprint2.Task4.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 4.189;
            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 20;
            double res = ds.Calculate(x, y);
            double wait = 420.6;
            Assert.AreEqual(wait, res);

        }
    }
}
