using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第七题
{
    /// <summary>
    /// 青蛙类
    /// </summary>
    class Frog:Animal
    {
        /// <summary>
        /// 重写父类中叫声的方法（青蛙）
        /// </summary>
        public override void Cry() {
            Console.WriteLine("呱呱呱呱。。。");
        }

        /// <summary>
        /// 重写父类中吃的方法（青蛙
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine("喜欢吃蚊子！！");
        }
    }
}
