using System;

namespace Season_One_Beginning
{
    class Program01
    {
        enum itemType
        {   //枚举
            coke, milktea, water, blackTea = 20 //可以修改值
        }

        static void Main(string[] args)
        {
            itemType shopItem = itemType.coke;

            Console.WriteLine(shopItem);
            //枚举类型有自己默认的值,但是要强制类型转换
            Console.WriteLine((int)shopItem);
        }
    }
}