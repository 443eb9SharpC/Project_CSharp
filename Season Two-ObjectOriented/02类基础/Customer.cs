using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Season_Two_ObjectOriented
{
    internal class Customer
    {
        public int m_id;
        public string m_name;
        public int m_age;
        public int m_joinYear;

        public int Age //属性
        {
            get { return m_age; }  //也可以把这行注释掉使m_age变为只写
            set
            {
                //默认会将传入的参数赋值给value
                if (value < 0) { return; }
                m_age = value;
            }
        }
        public string Addr { private get /*单独设置权限*/ ; set; }
        public Customer(int id, string name, int age, int joinYear)  //构造函数
        {
            m_id = id;
            m_name = name;
            m_age = age;
            m_joinYear = joinYear;
        }
    }
}
