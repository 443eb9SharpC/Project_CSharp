using System;

namespace Season_One_Beginning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("输入a和b的值:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a + b;

            Console.WriteLine(a);

            //索引,后面的值可不用也可多次使用
            Console.WriteLine("{0}+{1}={2}", a, b, c);

            Console.Write("输入需要分离个十百位的三位数: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int third = num / 100;
            int second = (num - third * 100) / 10;
            int first = num - third * 100 - second * 10;

            Console.WriteLine(num);
            Console.WriteLine("百位: " + third);
            Console.WriteLine("十位: " + second);
            Console.WriteLine("个位: " + first);
        }
    }
}