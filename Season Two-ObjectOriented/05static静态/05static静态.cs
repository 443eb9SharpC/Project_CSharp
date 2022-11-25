using Season_Two_ObjectOriented._05static静态;
using System;

namespace Season_Two_ObjectOriented
{
    class Program02
    {
        static void Main(string[] args)
        {
            Test t1= new Test();
            //t1.EgFunc();  //静态的东西用类名访问
            Test.EgFunc();
        }
    }
}