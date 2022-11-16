using Season_Two_ObjectOriented.类;
using System;

namespace Season_Two_ObjectOriented
{
    class Program02
    {
        static void Main(string[] args)
        {
            Customer customerA = new Customer(001, "张三", 30, 2020);
            
            customerA.Age = 30;  //属性可以直接拿来修改
        }
    }
}