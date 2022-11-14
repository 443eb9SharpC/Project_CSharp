using System;

namespace Season_One_Beginning
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("你想购买: ");
            int item = Convert.ToInt32(Console.ReadLine());

            switch (item)
            {
                case 1:
                    Console.WriteLine("矿泉水");
                    break;
                case 2:
                    Console.WriteLine("红茶");
                    break;
                case 3:
                    Console.WriteLine("绿茶");
                    break;
                default:
                    Console.WriteLine("无你想要的");
                    break;
            }
        }
    }
}