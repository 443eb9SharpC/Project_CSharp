using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Season_Two_ObjectOriented._05static静态
{
    internal class Test
    {
        //static的东西是公用的
        public static int speed;
        public int hp;
        public static void EgFunc()
        {
            //静态函数只能使用静态变量
            Console.WriteLine(speed);
        }
    }
}
