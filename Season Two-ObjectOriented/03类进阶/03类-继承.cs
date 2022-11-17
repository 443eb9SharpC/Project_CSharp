using Season_Two_ObjectOriented._03类进阶;
using System;

namespace Season_Two_ObjectOriented
{
    class Program02
    {
        static void Main(string[] args)
        {
            BaseClass bc1= new BaseClass();
            bc1.data1 = 123;
            bc1.data2 = "abc";
            bc1.DisplayClass();
        }
    }
}