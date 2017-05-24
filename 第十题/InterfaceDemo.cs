using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第十题
{
    class InterfaceDemo
    {
        static void Main(string[] args)
        {
            //父类的引用指向子类的对象
            Vehicle v = new Bike();
            v.start();
            v.stop();
            Console.WriteLine("------------------");
            //父类的引用指向子类的对象
            Vehicle v1 = new Bus();
            v1.start();
            v1.stop();
            Console.ReadKey();

        }
    }
}
