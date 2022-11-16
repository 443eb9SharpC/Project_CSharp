using System;

namespace Season_One_Beginning
{
    class Program01
    {
        static int Sum(int[] nums)
        {
            int sum = 0;
            foreach (int temp in nums)
            {
                sum += temp;
            }
            return sum;
        }

        //params关键字: 将传入的数字打包成数组
        static int AdvancedSum(params int[] nums)
        {
            int sum = 0;
            foreach (int temp in nums)
            {
                sum += temp;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int aaa = Sum(new int[] { 1, 2, 3, 4, 5, 6 });  //必须new int[],不能传入{1,2,3,4,5,6}
            Console.WriteLine(aaa);

            int bbb = AdvancedSum(1, 2, 3, 4, 5, 6, 7, 8, 9);
            Console.WriteLine(bbb);
        }
    }
}