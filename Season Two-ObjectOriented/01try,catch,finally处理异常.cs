using System;

namespace Season_Two_ObjectOriented
{
    class Program02
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };

            try
            {
                //下标越界了
                //try语句尝试运行
                Console.WriteLine(arr[100]);
            }
            catch(IndexOutOfRangeException exception)
            {
                //catch语句尝试捕捉出现的错误并在捕捉成功后运行下面的代码
                Console.WriteLine("发生了IndexOutOfRangeException错误");
                Console.WriteLine(exception);
            }
            finally
            {
                //不管有没有错误都会执行的语句
                Console.WriteLine("异常捕捉完毕");
            }

            Console.WriteLine("随便输出点东西");
        }
    }
}