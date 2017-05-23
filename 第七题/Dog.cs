using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第七题
{
    /// <summary>
    /// 狗类
    /// </summary>
    class Dog:Animal
    {
        /// <summary>
        /// 重写父类中叫声的方法（狗）
        /// </summary>
        public override void Cry()
        {
            Console.WriteLine("汪汪汪。。。");
        }

        /// <summary>
        /// 重写父类中吃的方法（狗）
        /// </summary>
        public override void Eat()
        {
            Console.WriteLine("喜欢吃骨头！！");
        }
    }
}
