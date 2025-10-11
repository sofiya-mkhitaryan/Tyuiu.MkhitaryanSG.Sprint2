//(|, &, ||, &&, !, ^)
//(True, True, True, False, True, False), при a = 654, b = 671, c = 874, d = 137
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MkhitaryanSG.Sprint2.Task1.V26.Lib
{
    public class DataService : ISprint2Task1V26
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a > b) | (b < c); //true
            res[1] = (a < b) & (d < b); //true
            res[2] = (b < d) || (d < a); // true
            res[3] = (d + 550 > a) && (c - 220 > b);  //false
            res[4] = !(!res[0]); //true
            res[5] = (c < d) ^ (a < d); //false

            return res;
        }
    }
}
