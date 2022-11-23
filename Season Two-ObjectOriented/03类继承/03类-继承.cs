using Season_Two_ObjectOriented._03类继承;
using System;

namespace Season_Two_ObjectOriented
{
    class Program02
    {
        static void Main(string[] args)
        {
            //在构造时必然先执行父类的构造函数
            //在调用子类的构造函数
            DrivedClass dc1 = new DrivedClass("abc", 123, 666);
            dc1.DisplayDrivedClass();
            dc1.DisplayBaseClass();
            Console.WriteLine(dc1.hp);
        }
    }
}