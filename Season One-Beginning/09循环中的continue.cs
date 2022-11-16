using System;

namespace Season_One_Beginning
{
    class Program01
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    //终止当前循环,开始下一循环
                    continue;
                }
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}