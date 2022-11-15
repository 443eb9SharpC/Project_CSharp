using System;

namespace Season_One_Beginning
{
    class Program
    {
        struct Student
        {
            public int id;
            public string name;
            public int age;
            public int gender;
        }
        struct Position
        {
            public double xPos;
            public double yPos;
            public double zPos;

            public void PrintPosition()
            {
                Console.WriteLine("(" + xPos + ", " + yPos + ", " + zPos + ")");
            }
        }
        static void Main(string[] args)
        {
            Student studentA;
            studentA.id = 0001;
            studentA.name = "A";
            studentA.age = 16;
            studentA.gender = 1;

            Console.WriteLine(studentA.id);
            Console.WriteLine(studentA.name);
            Console.WriteLine(studentA.age);
            if (studentA.gender == 0)
            {
                Console.WriteLine("Boy");
            }
            else
            {
                Console.WriteLine("Girl");
            }

            Student[] students = new Student[10];
            students[0] = studentA;
            Console.WriteLine(students[0].name);

            Position posA;
            posA.xPos = 2.1656;
            posA.yPos = 6.1523;
            posA.zPos = 8.1638;

            posA.PrintPosition();
        }
    }
}