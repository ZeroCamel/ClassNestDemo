using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNestDemo
{
    public class Person
    {
        public  class Student
        {
            public static int age;
            public static int height;
            public static string sex;

            public virtual void show()
            {
                Console.WriteLine("年龄："+age);
                Console.WriteLine("身高：" + height);
            }
            internal void Display()
            {
                Console.WriteLine("Internal");
                Console.WriteLine("年龄：" + age);
                Console.WriteLine("身高：" + height);
            }
        }

        public void Show()
        {
            Student.age = 10;
            Student.height = 150;
            Student.sex = "MAN";
            Student student = new Student();
            student.show();
            student.Display();
        }
    }
}

