using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Season_Two_ObjectOriented._04类多态
{
    internal class Weapon : ItemAbstract
    {
        //继承后重写
        public override void SetType(int type)
        {
            this.type = "weapon";
        }
    }
}
