﻿//если x + 20 > y * 2, то z = x*((y+1)/(x+2))^x иначе y^2 + 2*x + (6/x)
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MkhitaryanSG.Sprint2.Task4.V6.Lib
{
    public class DataService : ISprint2Task4V6
    {
        public double Calculate(double x, double y)
        {
            double z = x + 20 > y * 2 ? x * Math.Pow(((y + 1) / (x + 2)), x) : Math.Pow(y, 2) + 2*x + 6/x;
            return Math.Round(z, 3);
        }
    }
}
