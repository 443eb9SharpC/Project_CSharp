using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Season_Two_ObjectOriented._03类继承
{
    internal class BaseClass
    {
        public string name;
        public int attack;
        public int hp;

        public void DisplayBaseClass()
        {
            Console.WriteLine(this.name + " " + this.attack + " " + this.hp);
        }
    }
}
