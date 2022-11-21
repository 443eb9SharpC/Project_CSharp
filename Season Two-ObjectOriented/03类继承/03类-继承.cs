using Season_Two_ObjectOriented._03类继承;
using System;

namespace Season_Two_ObjectOriented
{
    class Program02
    {
        static void Main(string[] args)
        {
            DrivedClass dc1 = new DrivedClass("abc", 123, 666);
            dc1.DisplayDrivedClass();
            dc1.DisplayBaseClass();
            Console.WriteLine(dc1.hp);
        }
    }
}