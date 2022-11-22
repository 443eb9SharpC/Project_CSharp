using Season_Two_ObjectOriented._04类多态;
using System;

namespace Season_Two_ObjectOriented
{
    class Program02
    {
        static void Main(string[] args)
        {
            Boss boss= new Boss();
            boss.Move();
            boss.AI();

            Enemy enemy;  //用父类声明
            enemy = new Boss();  //用子类构造
            enemy.Move();  //虚方法调用子类的函数
            enemy.AI();  //隐藏方法调用父类函数
            //enemy.BossSkill1();  无法使用子类的特有的

            //Boss boss1 = new Enemy();  子类不能用父类构造
        }
    }
}