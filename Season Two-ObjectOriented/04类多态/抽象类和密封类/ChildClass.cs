using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Season_Two_ObjectOriented._04类多态.抽象类和密封类
{
    //同理,sealed可以把类变成不可继承的类
    internal class ChildClass : BaseClass
    {
        //sealed即将函数变为不可再次被重写的函数
        //防止代码混乱
        public sealed override void ShowSth()
        {
            Console.WriteLine("举不出例子了，随便写吧");
        }
    }
}
