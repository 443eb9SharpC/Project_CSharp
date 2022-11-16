using System;

namespace Season_One_Beginning
{
    class Program01
    {
        static void Main(string[] args)
        {
            string[] name = { "aaa", "bbb", "ccc", "ddd" };

            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(name[i] + " ");
            }
            Console.WriteLine();

            //foreach遍历
            //即取出每一个name[]中的值赋给temp
            foreach (string temp in name)
            {
                Console.Write(temp + " ");
            }
            Console.WriteLine();

            int[] age;
            age = new int[5]; //以默认值赋值

            string str1 = " aaa bbb ";
            string str2 = str1.Trim();  //去除字符串中的空格
            string str3 = str1.TrimStart();  //去除开头的空格
            string str4 = str1.TrimEnd();  //去除末尾的空格

            Console.WriteLine("str1=" + str1);
            Console.WriteLine("str2=" + str2);
            Console.WriteLine("str3=" + str3);
            Console.WriteLine("str4=" + str4);

            string names = "aaa,bbb,ccc";
            //以","分割字符串并输出至一个数组
            string[] nameArr = names.Split(',');
            foreach (string temp in nameArr)
            {
                Console.Write(temp + " ");
            }
            Console.WriteLine();
        }
    }
}