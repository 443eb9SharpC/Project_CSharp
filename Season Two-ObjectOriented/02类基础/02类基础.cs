using System;

namespace Season_Two_ObjectOriented
{
    class Program02
    {
        static void Main(string[] args)
        {
            Customer customerA = new Customer(001, "张三", 30, 2020);
            
            customerA.Age = 30;  //属性可以直接拿来修改
            customerA.Addr = "Zhejiang";  //自动创建Addr

            var name = "李四";  //匿名数据类型,编译器自动推导
            Console.WriteLine(name);

            Customer customerB = new Customer(002, "李四", 25, 2021);
            Customer customerC = customerB;  //这是浅拷贝,仅复制地址
            customerC.m_age = 27;  //因此在修改customerC的参数时,customerB的也会被修改
        }
    }
}