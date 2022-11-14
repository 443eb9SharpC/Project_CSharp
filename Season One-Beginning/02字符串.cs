using System;

namespace Season_One_Beginning
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "123";
            string b = "456";

            string c = Console.ReadLine();

            Console.WriteLine(a + b);
            //string -> int
            //只能转换string
            int d = Convert.ToInt32(c);
            Console.WriteLine(d);
        }
    }
}