using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第七题
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 7：动物都会有不同的叫声，但是各不相同，青蛙的叫声是“呱呱呱”，猫的叫声是喵喵喵，狗的叫声的汪汪汪，强盗的叫声是“…”，每种动物都有自己独特的喜好。请尝试输出各种不同动物的爱好。 请分别创建不同的类，使用动物类型的通用方法来完成编程，让叫这个方法输出不 同的信息: 使用动物类型的不同对象，输出不同的叫声信息。

           //青蛙
            Animal a1 = new Frog();
            a1.Cry();
            a1.Eat();
            Console.WriteLine("----------------------");
            //猫
            Animal a2 = new Cats();
            a2.Cry();
            a2.Eat();
            Console.WriteLine("----------------------");
            //狗
            Animal a3 = new Dog();
            a3.Cry();
            a3.Eat();
            Console.WriteLine("----------------------");

            Console.ReadKey();

            #endregion
        }
    }
}
