using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Season_Two_ObjectOriented._04类多态
{
    //抽象类
    internal abstract class ItemAbstract
    {
        public string name;
        public string type;

        public void ShowName()
        {
            Console.WriteLine(this.name);
        }

        //抽象函数不用写实现
        public abstract void SetType(int type);
    }
}
