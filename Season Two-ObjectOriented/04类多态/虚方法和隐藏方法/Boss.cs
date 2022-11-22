using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Season_Two_ObjectOriented._04类多态
{
    internal class Boss : Enemy
    {
        //虚方法重写
        public override void Move()
        {
            Console.WriteLine("Boss正在移动");
        }

        public void BossSkill1()
        {
            Console.WriteLine("Boss技能1");
        }

        //隐藏方法重写
        public new void AI()
        {
            Console.WriteLine("Boss的AI");
        }
    }
}
