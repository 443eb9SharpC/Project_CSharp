using System;

namespace Season_One_Beginning
{
    class Program01
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