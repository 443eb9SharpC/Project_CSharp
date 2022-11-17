using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Season_Two_ObjectOriented._03类进阶
{
    internal class BaseClass
    {
        public int data1;
        public string data2;

        public void DisplayClass()
        {
            Console.WriteLine(data1+ " " + data2);
        }
    }
}
