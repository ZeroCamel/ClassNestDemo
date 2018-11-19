using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNestDemo
{
    public interface IObject
    {
        void printName();
    }
    public class ClassExam:IObject
    {
        private string name = "default name";
        public  ClassExam()
        {

        }
        public ClassExam(string name)
        {
            this.name = name;
        }
        public void printName()
        {
            Console.WriteLine(this.name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            //Person p = new Person();
            //p.Show();

            //SubPerson p = new SubPerson();
            //p.Show();

            //object a=Activator.CreateInstance("GameStatistical.Test.InnerClass", "GameStatistical.Test.InnerClass.ReflectionPerson+Student");

            //TODO:Implement Functionality Here--
            //反射-输入类返回当前的实例 包含有构造函数和无构造函数
            //工厂模式动态创建类的实例
            //1. Activator.CreateInstance (Type) 无参构造函数
            //2. Activator.CreateInstance (Type, Object[]) 有参构造函数
            IObject obj1 = (IObject)Activator.CreateInstance(System.Type.GetType("ClassNestDemo.ClassExam"));
            obj1.printName();

            IObject obj2 = (IObject)Activator.CreateInstance(System.Type.GetType("ClassNestDemo.ClassExam"), new string[] { "seted new name" });
            obj2.printName();

            Console.WriteLine("Press any key to  continue...");
            Console.ReadKey(true);
        }
    }
}
