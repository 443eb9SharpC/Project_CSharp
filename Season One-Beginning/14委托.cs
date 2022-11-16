using System;

namespace Season_One_Beginning
{
    class Program01
    {
        static double Multiply(double a, double b)
        {
            return a * b;
        }
        static double Divide(double a, double b)
        {
            return a / b;
        }

        //委托就是函数指针
        delegate double DelegateA(double a, double b);
        static void Main(string[] args)
        {
            DelegateA mydelegate;
            mydelegate = Multiply;

            double c = mydelegate(2.51, 4.32);
            Console.WriteLine(c);
        }
    }
}