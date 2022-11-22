using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Season_Two_ObjectOriented._04类多态
{
    internal class Enemy
    {
        public virtual void Move()
        {
            Console.WriteLine("敌人正在移动");
        }

        public void AI()
        {
            Console.WriteLine("敌人的AI");
        }
    }
}
