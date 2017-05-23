using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第七题
{
    /// <summary>
    /// 猫类
    /// </summary>
    class Cats:Animal
    {
        /// <summary>
        /// 重写父类中叫声的方法（猫）
        /// </summary>
        public override void Cry()
        {
            Console.WriteLine("喵喵喵。。。");
        }

        /// <summary>
        /// 重写父类中吃的方法（猫）
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine("喜欢鱼！！");
        }
    }
}
