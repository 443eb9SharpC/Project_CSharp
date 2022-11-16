using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Season_Two_ObjectOriented.类
{
    internal class Customer
    {
        public int m_id;
        public string m_name;
        public int m_age;
        public int m_joinYear;

        public int Age //属性
        {
            get { return m_age; }
            set { this.m_age = value; }  //默认会将传入的参数赋值给value
        }
        public Customer(int id, string name, int age, int joinYear)  //构造函数
        {
            this.m_id = id;
            this.m_name = name;
            this.m_age = age;
            this.m_joinYear = joinYear;
        }
    }
}
