using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Season_Two_ObjectOriented._03类继承
{
    internal class DrivedClass : BaseClass
    {
        public string name;
        public int attack;
        public int hp;

        public DrivedClass(string name, int attack, int hp)
        {
            this.attack = attack;  //this指向这个的值
            base.hp = hp;  //base指向父类的值
            this.name = name;
        }

        public void DisplayDrivedClass()
        {
            Console.WriteLine(this.name + " " + base.attack + " " + this.hp);
        }
    }
}
