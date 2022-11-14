using System;

namespace Season_One_Beginning
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 10000)
            {
                Console.WriteLine(i++);

                while (i < 1000)
                {
                    Console.WriteLine("WARN");
                    i++;
                }
            }
        }
    }
}