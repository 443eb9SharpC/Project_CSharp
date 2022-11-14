using System;

namespace Season_One_Beginning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(a);
            }
            else if (a > c)
            {
                Console.WriteLine(b);
            }
            else{
                Console.WriteLine(c);
            }
        }
    }
}